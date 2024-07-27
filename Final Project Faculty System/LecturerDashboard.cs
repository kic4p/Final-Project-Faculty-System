using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Final_Project_Faculty_System
{
	public partial class LecturerDashboard : Form
	{
		private string lecturerUsername;
		private string lecturerFullName;
		private Dictionary<string, List<string>> selectedGroups = new Dictionary<string, List<string>>();
		private string connectionString = @"Server=.\SQLEXPRESS;Database=Faculty System;Trusted_Connection=True;TrustServerCertificate=True;";

		public LecturerDashboard(string fullName)
		{
			InitializeComponent();
			lecturerFullName = fullName;
			lecturerUsername = GetLecturerUsername(fullName);
		}

		private void LecturerDashboard_Load(object sender, EventArgs e)
		{
			lbl_lecturer_fullName.Text = "Lecturer: " + CapitalizeEachWord(lecturerFullName);
			PopulateCourseDropdown();
			PopulateCourseDropdownDelete();
			PopulateCourseTabs();
			PopulateViewCourseTabs();
		}

		private string CapitalizeEachWord(string input)
		{
			if (string.IsNullOrWhiteSpace(input))
				return string.Empty;

			var words = input.Split(' ');

			for (int i = 0; i < words.Length; i++)
			{
				if (words[i].Length > 0)
				{
					words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
				}
			}
			return string.Join(" ", words);
		}

		private string GetLecturerUsername(string fullName)
		{
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				conn.Open();
				string query = "SELECT Username FROM Lecturers WHERE FullName = @FullName";
				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					cmd.Parameters.AddWithValue("@FullName", fullName);

					var result = cmd.ExecuteScalar();
					if (result != null)
					{
						return result.ToString();
					}
					else
					{
						throw new Exception("Lecturer username not found for the given name.");
					}
				}
			}
		}

		private void btn_logout_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				this.Close();
				Form1 loginForm = new Form1();
				loginForm.Show();
			}
		}

		private void PopulateCourseDropdown()
		{
			comBox_courseList.Items.Clear();

			List<string> courses = new List<string>
			{
				"IAS1313 - Object Oriented Programming",
				"IAS2263 - System Analysis and Design",
				"IAS2233 - Computer Graphics",
				"IAS3233 - Expert System",
				"ISS2263 - Software Design Architecture",
				"ISS3163 - Software Maintenance and Evolution",
				"ISS2273 - Software Quality Assurance",
				"MPU3352 - Integriti dan Anti Rasuah",
				"MPU3492 - Contemporary Da'wah",
				"MPU3242 - Interactive Exploration of The Quran"
			};

			foreach (var course in courses)
			{
				comBox_courseList.Items.Add(course);
			}

			comBox_courseList.SelectedIndex = 0;
		}

		private void comBox_courseList_SelectedIndexChanged(object sender, EventArgs e)
		{
			ResetGroupButtons();
		}

		private string GetSelectedGroup()
		{
			if (radio_g1.Checked) return "Group 1";
			if (radio_g2.Checked) return "Group 2";
			if (radio_g3.Checked) return "Group 3";
			if (radio_g4.Checked) return "Group 4";
			if (radio_g5.Checked) return "Group 5";
			if (radio_g6.Checked) return "Group 6";
			return null;
		}

		private void btn_create_Click(object sender, EventArgs e)
		{
			string selectedCourse = comBox_courseList.SelectedItem?.ToString();
			string selectedGroup = GetSelectedGroup();

			if (string.IsNullOrEmpty(selectedCourse) || string.IsNullOrEmpty(selectedGroup))
			{
				MessageBox.Show("Please select both a course and a group.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			string[] courseParts = selectedCourse.Split(new string[] { " - " }, StringSplitOptions.None);
			if (courseParts.Length < 2)
			{
				MessageBox.Show("Invalid course format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			string courseCode = courseParts[0];
			string courseName = courseParts[1];
			string fullCourseCode = $"{courseCode}.G{selectedGroup.Replace("Group ", "")}";

			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();
					string insertCourseQuery = "INSERT INTO Courses (CourseCode, CourseName, GroupNumber, Username) VALUES (@CourseCode, @CourseName, @GroupNumber, @Username)";
					using (SqlCommand cmd = new SqlCommand(insertCourseQuery, conn))
					{
						cmd.Parameters.AddWithValue("@CourseCode", fullCourseCode);
						cmd.Parameters.AddWithValue("@CourseName", courseName);
						cmd.Parameters.AddWithValue("@GroupNumber", selectedGroup.Replace("Group ", ""));
						cmd.Parameters.AddWithValue("@Username", lecturerUsername);

						cmd.ExecuteNonQuery();
					}

					string newTableName = fullCourseCode;
					string createTableQuery = $@"
            CREATE TABLE [{newTableName}] (
                StudentID VARCHAR(10) PRIMARY KEY,
                FullName NVARCHAR(100),
                PhoneNumber VARCHAR(15),
                ProgramCode VARCHAR(10)
            )";

					using (SqlCommand cmd = new SqlCommand(createTableQuery, conn))
					{
						cmd.ExecuteNonQuery();
					}

					MessageBox.Show("Course has been created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

					// Refresh the dropdown and tabs
					PopulateCourseDropdownDelete();
					PopulateCourseTabs(); // Refreshes the update data section
					PopulateViewCourseTabs(); // Refreshes the view data section
				}
			}
			catch (SqlException ex) when (ex.Number == 2627)
			{
				MessageBox.Show($"The course '{fullCourseCode} - {courseName}' already exists.", "Duplicate Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void ResetGroupButtons()
		{
			radio_g1.Enabled = true;
			radio_g2.Enabled = true;
			radio_g3.Enabled = true;
			radio_g4.Enabled = true;
			radio_g5.Enabled = true;
			radio_g6.Enabled = true;

			radio_g1.Checked = false;
			radio_g2.Checked = false;
			radio_g3.Checked = false;
			radio_g4.Checked = false;
			radio_g5.Checked = false;
			radio_g6.Checked = false;
		}

		private void TrackGroupSelection(string course, string group)
		{
			if (!selectedGroups.ContainsKey(course))
			{
				selectedGroups[course] = new List<string>();
			}

			selectedGroups[course].Add(group);

			UpdateGroupAvailability(course);

			if (selectedGroups[course].Count == 6)
			{
				comBox_courseList.Items.Remove(course);
			}
		}

		private void UpdateGroupAvailability(string course)
		{
			ResetGroupButtons();

			if (selectedGroups.ContainsKey(course))
			{
				radio_g1.Enabled = !selectedGroups[course].Contains("Group 1");
				radio_g2.Enabled = !selectedGroups[course].Contains("Group 2");
				radio_g3.Enabled = !selectedGroups[course].Contains("Group 3");
				radio_g4.Enabled = !selectedGroups[course].Contains("Group 4");
				radio_g5.Enabled = !selectedGroups[course].Contains("Group 5");
				radio_g6.Enabled = !selectedGroups[course].Contains("Group 6");
			}
		}

		private void PopulateCourseDropdownDelete()
		{
			comBox_delete.Items.Clear();

			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();

					string query = "SELECT CourseCode, CourseName, GroupNumber FROM Courses WHERE Username = @Username";
					using (SqlCommand cmd = new SqlCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("@Username", lecturerUsername);
						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							while (reader.Read())
							{
								string courseCode = reader["CourseCode"].ToString();
								string courseName = reader["CourseName"].ToString();
								string groupNumber = reader["GroupNumber"].ToString();
								string displayText = $"{courseCode} - {courseName} - Group {groupNumber}";
								comBox_delete.Items.Add(displayText);
							}
						}
					}
				}

				if (comBox_delete.Items.Count > 0)
				{
					comBox_delete.SelectedIndex = 0;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error fetching courses: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_delete_course_Click(object sender, EventArgs e)
		{
			string selectedCourse = comBox_delete.SelectedItem?.ToString();
			if (string.IsNullOrEmpty(selectedCourse))
			{
				MessageBox.Show("Please select a course to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			string[] courseParts = selectedCourse.Split(new string[] { " - " }, StringSplitOptions.None);
			if (courseParts.Length < 1)
			{
				MessageBox.Show("Invalid course format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			string courseCode = courseParts[0];

			DialogResult result = MessageBox.Show($"Do you want to delete {selectedCourse} from your class?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(connectionString))
					{
						conn.Open();

						// 1. Delete from Courses table
						string deleteCourseQuery = "DELETE FROM Courses WHERE CourseCode = @CourseCode";
						using (SqlCommand cmd = new SqlCommand(deleteCourseQuery, conn))
						{
							cmd.Parameters.AddWithValue("@CourseCode", courseCode);
							cmd.ExecuteNonQuery();
						}

						// 2. Drop the individual course table
						string dropTableQuery = $"DROP TABLE IF EXISTS [{courseCode}]";
						using (SqlCommand cmd = new SqlCommand(dropTableQuery, conn))
						{
							cmd.ExecuteNonQuery();
						}

						// 3. Update the CourseCode in Students table
						string updateCourseCodes = "UPDATE Students SET CourseCode = " +
												   "CASE WHEN LEN(CourseCode) = LEN(@CourseCode) THEN '' " +
												   "WHEN CourseCode LIKE @CourseCode + ', %' THEN STUFF(CourseCode, 1, LEN(@CourseCode) + 2, '') " +
												   "WHEN CourseCode LIKE '%, ' + @CourseCode THEN STUFF(CourseCode, LEN(CourseCode) - LEN(@CourseCode) - 1, LEN(@CourseCode) + 2, '') " +
												   "ELSE REPLACE(CourseCode, ', ' + @CourseCode, '') END " +
												   "WHERE CourseCode LIKE '%' + @CourseCode + '%'";

						using (SqlCommand cmd = new SqlCommand(updateCourseCodes, conn))
						{
							cmd.Parameters.AddWithValue("@CourseCode", courseCode);
							cmd.ExecuteNonQuery();
						}

						// Set CourseCode to NULL if it's empty
						string nullEmptyCourseCodes = "UPDATE Students SET CourseCode = NULL WHERE LEN(CourseCode) = 0";
						using (SqlCommand cmd = new SqlCommand(nullEmptyCourseCodes, conn))
						{
							cmd.ExecuteNonQuery();
						}

						MessageBox.Show("Course and its records have been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

						// Refresh the course tabs
						PopulateCourseDropdownDelete();
						PopulateCourseTabs();
						PopulateViewCourseTabs();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btn_delete_all_Click(object sender, EventArgs e)
		{
			DialogResult firstConfirmation = MessageBox.Show("Do you want to delete all courses that you're currently teaching?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (firstConfirmation == DialogResult.Yes)
			{
				DialogResult secondConfirmation = MessageBox.Show("WARNING! THE ACTION IS IRREVERSIBLE. YOU CANNOT RECOVER ONCE DELETED.", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (secondConfirmation == DialogResult.Yes)
				{
					try
					{
						using (SqlConnection conn = new SqlConnection(connectionString))
						{
							conn.Open();

							// Get all course codes for the lecturer
							string getCoursesQuery = "SELECT CourseCode FROM Courses WHERE Username = @Username";
							List<string> courseCodes = new List<string>();

							using (SqlCommand cmd = new SqlCommand(getCoursesQuery, conn))
							{
								cmd.Parameters.AddWithValue("@Username", lecturerUsername);
								using (SqlDataReader reader = cmd.ExecuteReader())
								{
									while (reader.Read())
									{
										courseCodes.Add(reader["CourseCode"].ToString());
									}
								}
							}

							foreach (var courseCode in courseCodes)
							{
								// 1. Delete from Courses table
								string deleteCourseQuery = "DELETE FROM Courses WHERE CourseCode = @CourseCode";
								using (SqlCommand cmd = new SqlCommand(deleteCourseQuery, conn))
								{
									cmd.Parameters.AddWithValue("@CourseCode", courseCode);
									cmd.ExecuteNonQuery();
								}

								// 2. Drop the individual course table
								string dropTableQuery = $"DROP TABLE IF EXISTS [{courseCode}]";
								using (SqlCommand cmd = new SqlCommand(dropTableQuery, conn))
								{
									cmd.ExecuteNonQuery();
								}

								// 3. Update the CourseCode in Students table
								string updateCourseCodes = "UPDATE Students SET CourseCode = " +
														   "CASE WHEN LEN(CourseCode) = LEN(@CourseCode) THEN '' " +
														   "WHEN CourseCode LIKE @CourseCode + ', %' THEN STUFF(CourseCode, 1, LEN(@CourseCode) + 2, '') " +
														   "WHEN CourseCode LIKE '%, ' + @CourseCode THEN STUFF(CourseCode, LEN(CourseCode) - LEN(@CourseCode) - 1, LEN(@CourseCode) + 2, '') " +
														   "ELSE REPLACE(CourseCode, ', ' + @CourseCode, '') END " +
														   "WHERE CourseCode LIKE '%' + @CourseCode + '%'";

								using (SqlCommand cmd = new SqlCommand(updateCourseCodes, conn))
								{
									cmd.Parameters.AddWithValue("@CourseCode", courseCode);
									cmd.ExecuteNonQuery();
								}
							}

							// Set CourseCode to NULL if it's empty
							string nullEmptyCourseCodes = "UPDATE Students SET CourseCode = NULL WHERE LEN(CourseCode) = 0";
							using (SqlCommand cmd = new SqlCommand(nullEmptyCourseCodes, conn))
							{
								cmd.ExecuteNonQuery();
							}

							MessageBox.Show("All courses and their records have been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

							comBox_delete.Items.Clear();

							// Refresh the dropdown and tabs
							PopulateCourseDropdownDelete();
							PopulateCourseTabs(); // Refreshes the update data section
							PopulateViewCourseTabs(); // Refreshes the view data section
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}


		private void PopulateCourseTabs()
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();
					string query = "SELECT CourseCode, CourseName, GroupNumber FROM Courses WHERE Username = @Username";
					using (SqlCommand cmd = new SqlCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("@Username", lecturerUsername);
						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							// Clear existing tabs
							tabControl1.TabPages.Clear();

							while (reader.Read())
							{
								string courseCode = reader["CourseCode"].ToString();
								string courseName = reader["CourseName"].ToString();
								string groupNumber = reader["GroupNumber"].ToString();
								string tabPageName = $"{courseCode}";

								// Check if the tab already exists
								if (!tabControl1.TabPages.ContainsKey(courseCode))
								{
									TabPage newTabPage = new TabPage(tabPageName);
									newTabPage.Name = courseCode;

									// Label for course title
									Label lbl_courseTitle = new Label
									{
										Name = "lbl_course_title",
										Text = $"Course: {courseCode} - {courseName} - Group {groupNumber}",
										AutoSize = true,
										Font = new Font("Source Sans 3", 13.8F, FontStyle.Bold, GraphicsUnit.Point),
										Location = new Point(22, 13)
									};

									// TextBox for adding a student
									TextBox txtbox_addStudent = new TextBox
									{
										Name = "txtbox_addStudent",
										Location = new Point(497, 80),
										Size = new Size(194, 27),
										Font = new Font("Source Sans 3 Medium", 9F, FontStyle.Bold, GraphicsUnit.Point)
									};

									// Button for adding a student
									Button btn_addStudent = new Button
									{
										Name = "btn_addStudent",
										Text = "Add Student",
										Location = new Point(708, 80),
										Size = new Size(160, 29),
										Font = new Font("Source Sans 3 Medium", 9F, FontStyle.Bold, GraphicsUnit.Point)
									};
									btn_addStudent.Click += (s, args) => AddStudentToCourse(txtbox_addStudent.Text, courseCode);

									// ComboBox for removing a student
									ComboBox comBox_removeStudent = new ComboBox
									{
										Name = "comBox_removeStudent",
										Location = new Point(497, 135),
										Size = new Size(371, 28),
										Font = new Font("Source Sans 3 Medium", 9F, FontStyle.Bold, GraphicsUnit.Point),
										DropDownWidth = 371,
										DropDownHeight = 106
									};

									// Button for removing a student
									Button btn_removeStudent = new Button
									{
										Name = "btn_removeStudent",
										Text = "Remove Student",
										Location = new Point(597, 198),
										Size = new Size(160, 29),
										Font = new Font("Source Sans 3 Medium", 9F, FontStyle.Bold, GraphicsUnit.Point),
										BackColor = Color.Red
									};
									btn_removeStudent.Click += (s, args) => RemoveStudentFromCourse(comBox_removeStudent.SelectedItem?.ToString(), courseCode);

									// Label for student count
									Label lbl_studentCount = new Label
									{
										Name = "lbl_student_count",
										Text = "Total Students: 0",
										AutoSize = true,
										Font = new Font("Source Sans 3", 12F, FontStyle.Bold, GraphicsUnit.Point),
										Location = new Point(22, 136)
									};

									newTabPage.Controls.Add(lbl_courseTitle);
									newTabPage.Controls.Add(txtbox_addStudent);
									newTabPage.Controls.Add(btn_addStudent);
									newTabPage.Controls.Add(comBox_removeStudent);
									newTabPage.Controls.Add(btn_removeStudent);
									newTabPage.Controls.Add(lbl_studentCount);

									tabControl1.TabPages.Add(newTabPage);

									PopulateStudentComboBox(comBox_removeStudent, courseCode);
									UpdateTotalStudentCount(courseCode, lbl_studentCount);
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error loading course tabs: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void PopulateViewCourseTabs()
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();
					string query = "SELECT CourseCode, CourseName FROM Courses WHERE Username = @Username";
					using (SqlCommand cmd = new SqlCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("@Username", lecturerUsername);
						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							tabControl2.TabPages.Clear();

							while (reader.Read())
							{
								string courseCode = reader["CourseCode"].ToString();
								string courseName = reader["CourseName"].ToString();

								TabPage tabPage = new TabPage(courseCode);
								DataGridView dataGridView = new DataGridView
								{
									Dock = DockStyle.Fill,
									ReadOnly = true,
									AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
								};

								LoadCourseData(courseCode, dataGridView);
								tabPage.Controls.Add(dataGridView);
								tabControl2.TabPages.Add(tabPage);

								// Ensure columns are loaded before accessing
								dataGridView.DataBindingComplete += (s, e) =>
								{
									if (dataGridView.Columns.Contains("StudentID"))
									{
										dataGridView.Columns["StudentID"].HeaderText = "Matric No";
									}
									if (dataGridView.Columns.Contains("FullName"))
									{
										dataGridView.Columns["FullName"].HeaderText = "Full Name";
									}
									if (dataGridView.Columns.Contains("PhoneNumber"))
									{
										dataGridView.Columns["PhoneNumber"].HeaderText = "Phone Number";
									}
									if (dataGridView.Columns.Contains("ProgramCode"))
									{
										dataGridView.Columns["ProgramCode"].HeaderText = "Program Code";
									}

									// Set column width percentages
									int formWidth = dataGridView.Width;
									if (dataGridView.Columns.Contains("StudentID"))
										dataGridView.Columns["StudentID"].Width = (int)(formWidth * 0.20);
									if (dataGridView.Columns.Contains("FullName"))
										dataGridView.Columns["FullName"].Width = (int)(formWidth * 0.50);
									if (dataGridView.Columns.Contains("PhoneNumber"))
										dataGridView.Columns["PhoneNumber"].Width = (int)(formWidth * 0.15);
									if (dataGridView.Columns.Contains("ProgramCode"))
										dataGridView.Columns["ProgramCode"].Width = (int)(formWidth * 0.15);
								};
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error loading view data tabs: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void LoadCourseData(string courseCode, DataGridView dataGridView)
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();
					string query = $"SELECT * FROM [{courseCode}]";
					using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
					{
						DataTable dataTable = new DataTable();
						adapter.Fill(dataTable);
						dataGridView.DataSource = dataTable;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error loading course data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}



		private void PopulateStudentComboBox(ComboBox comboBox, string courseCode)
		{
			comboBox.Items.Clear();

			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();
					string query = $"SELECT StudentID, FullName FROM [{courseCode}]";
					using (SqlCommand cmd = new SqlCommand(query, conn))
					{
						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							while (reader.Read())
							{
								string studentID = reader["StudentID"].ToString();
								string fullName = reader["FullName"].ToString();
								comboBox.Items.Add($"{fullName} ({studentID})");
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error loading students: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void AddStudentToCourse(string studentID, string courseCode)
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();

					// Extract the base course code without the group part (e.g., IAS3213 from IAS3213.G1)
					string baseCourseCode = courseCode.Split('.')[0];

					// Check if the student is already in another group of the same course
					string checkGroupQuery = "SELECT CourseCode FROM Students WHERE StudentID = @StudentID AND CourseCode LIKE @BaseCourseCode + '.G%'";
					using (SqlCommand cmd = new SqlCommand(checkGroupQuery, conn))
					{
						cmd.Parameters.AddWithValue("@StudentID", studentID);
						cmd.Parameters.AddWithValue("@BaseCourseCode", baseCourseCode);
						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							if (reader.Read())
							{
								string existingCourseCode = reader["CourseCode"].ToString();
								MessageBox.Show($"Error: The student is already enrolled in another group ({existingCourseCode}).", "Enrollment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
								return;
							}
						}
					}

					// Retrieve student information from the Students table
					string queryStudent = "SELECT FullName, PhoneNumber, ProgramCode FROM Students WHERE StudentID = @StudentID";
					string fullName, phoneNumber, programCode;

					using (SqlCommand cmd = new SqlCommand(queryStudent, conn))
					{
						cmd.Parameters.AddWithValue("@StudentID", studentID);
						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							if (reader.Read())
							{
								fullName = reader["FullName"].ToString();
								phoneNumber = reader["PhoneNumber"].ToString();
								programCode = reader["ProgramCode"].ToString();
							}
							else
							{
								MessageBox.Show("Student not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
								return;
							}
						}
					}

					// Add the student to the course table
					string insertQuery = $"INSERT INTO [{courseCode}] (StudentID, FullName, PhoneNumber, ProgramCode) VALUES (@StudentID, @FullName, @PhoneNumber, @ProgramCode)";
					using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
					{
						cmd.Parameters.AddWithValue("@StudentID", studentID);
						cmd.Parameters.AddWithValue("@FullName", fullName);
						cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
						cmd.Parameters.AddWithValue("@ProgramCode", programCode);
						cmd.ExecuteNonQuery();
					}

					// Update the course codes in the Students table
					string updateCourseCodes = "UPDATE Students SET CourseCode = CONCAT(COALESCE(CourseCode, ''), CASE WHEN LEN(CourseCode) > 0 THEN ', ' ELSE '' END, @CourseCode) WHERE StudentID = @StudentID";
					using (SqlCommand cmd = new SqlCommand(updateCourseCodes, conn))
					{
						cmd.Parameters.AddWithValue("@CourseCode", courseCode);
						cmd.Parameters.AddWithValue("@StudentID", studentID);
						cmd.ExecuteNonQuery();
					}

					MessageBox.Show("Student added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}

				RefreshCourseTab(courseCode);
				PopulateCourseTabs();
				PopulateViewCourseTabs();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error adding student to course: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void RemoveStudentFromCourse(string studentDisplayName, string courseCode)
		{
			try
			{
				if (string.IsNullOrEmpty(studentDisplayName) || string.IsNullOrEmpty(courseCode))
				{
					MessageBox.Show("Invalid student or course selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				// Extract StudentID from the display string (assuming the format is "FullName (StudentID)")
				var match = Regex.Match(studentDisplayName, @"\((\d+)\)$");
				if (!match.Success)
				{
					MessageBox.Show("Invalid student selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				string studentID = match.Groups[1].Value;

				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();

					// Delete the student from the course table
					string deleteQuery = $"DELETE FROM [{courseCode}] WHERE StudentID = @StudentID";
					using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
					{
						cmd.Parameters.AddWithValue("@StudentID", studentID);
						cmd.ExecuteNonQuery();
					}

					// Remove the course code from the Students table's CourseCode field
					string updateCourseCodes = "UPDATE Students SET CourseCode = " +
											   "CASE " +
											   "WHEN LEN(CourseCode) = LEN(@CourseCode) THEN '' " +
											   "WHEN CourseCode LIKE @CourseCode + ', %' THEN STUFF(CourseCode, 1, LEN(@CourseCode) + 2, '') " +
											   "WHEN CourseCode LIKE '%, ' + @CourseCode THEN STUFF(CourseCode, LEN(CourseCode) - LEN(@CourseCode) - 1, LEN(@CourseCode) + 2, '') " +
											   "ELSE REPLACE(CourseCode, ', ' + @CourseCode, '') END " +
											   "WHERE StudentID = @StudentID";
					using (SqlCommand cmd = new SqlCommand(updateCourseCodes, conn))
					{
						cmd.Parameters.AddWithValue("@CourseCode", courseCode);
						cmd.Parameters.AddWithValue("@StudentID", studentID);
						cmd.ExecuteNonQuery();
					}

					// Set CourseCode to NULL if it's empty
					string nullEmptyCourseCodes = "UPDATE Students SET CourseCode = NULL WHERE LEN(CourseCode) = 0";
					using (SqlCommand cmd = new SqlCommand(nullEmptyCourseCodes, conn))
					{
						cmd.ExecuteNonQuery();
					}

					MessageBox.Show("Student removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}

				// Refresh the course tab and data views
				RefreshCourseTab(courseCode);
				PopulateCourseTabs();
				PopulateViewCourseTabs();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error removing student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void RefreshCourseTab(string courseCode)
		{
			foreach (TabPage tabPage in tabControl1.TabPages)
			{
				if (tabPage.Name == courseCode)
				{
					ComboBox comBox_removeStudent = tabPage.Controls.OfType<ComboBox>().FirstOrDefault(c => c.Name == "comBox_removeStudent");
					Label lbl_studentCount = tabPage.Controls.OfType<Label>().FirstOrDefault(l => l.Name == "lbl_student_count");

					if (comBox_removeStudent != null && lbl_studentCount != null)
					{
						PopulateStudentComboBox(comBox_removeStudent, courseCode);
						UpdateTotalStudentCount(courseCode, lbl_studentCount);
					}
					break;
				}
			}
		}

		private void UpdateTotalStudentCount(string courseCode, Label lbl_studentCount)
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();
					string query = $"SELECT COUNT(*) FROM [{courseCode}]";
					using (SqlCommand cmd = new SqlCommand(query, conn))
					{
						int studentCount = (int)cmd.ExecuteScalar();
						lbl_studentCount.Text = $"Total Students: {studentCount}";
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error updating total student count: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
