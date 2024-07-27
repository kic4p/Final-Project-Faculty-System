using Final_Project_Faculty_System;
using Microsoft.Data.SqlClient;

public partial class StudentDashboard : Form
{
	private string studentID;
	private string connectionString = @"Server=.\SQLEXPRESS;Database=Faculty System;Trusted_Connection=True;TrustServerCertificate=True;";

	public StudentDashboard(string studentID)
	{
		InitializeComponent();
		this.studentID = studentID;
		LoadStudentData();
		LoadAvailableCourses();
	}

	public class Course
	{
		public string CourseCode { get; set; }
		public string CourseName { get; set; }
		public int GroupNumber { get; set; }

		public Course(string courseCode, string courseName, int groupNumber)
		{
			CourseCode = courseCode;
			CourseName = courseName;
			GroupNumber = groupNumber;
		}

		public override string ToString()
		{
			return CourseName; // Display only course name in ComboBox
		}
	}

	private void LoadStudentData()
	{
		try
		{
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				conn.Open();
				string query = "SELECT FullName FROM Students WHERE StudentID = @StudentID";
				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					cmd.Parameters.AddWithValue("@StudentID", studentID);
					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						if (reader.Read())
						{
							string fullName = reader["FullName"].ToString();
							lbl_student_fullName.Text = "Student: " + CapitalizeEachWord(fullName);
						}
						else
						{
							MessageBox.Show("Student not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show($"Error loading student data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
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

	private void btn_logout_student_Click(object sender, EventArgs e)
	{
		var result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		if (result == DialogResult.Yes)
		{
			this.Close();
			StudentLogin loginForm = new StudentLogin();
			loginForm.Show();
		}
	}

	private void LoadAvailableCourses()
	{
		try
		{
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				conn.Open();

				string courseQuery = "SELECT CourseCode, CourseName, GroupNumber FROM Courses ORDER BY CourseName, GroupNumber";
				List<Course> courses = new List<Course>();

				using (SqlCommand cmd = new SqlCommand(courseQuery, conn))
				{
					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							string courseCode = reader["CourseCode"].ToString();
							string courseName = reader["CourseName"].ToString();
							int groupNumber = int.Parse(reader["GroupNumber"].ToString());
							courses.Add(new Course(courseCode, courseName, groupNumber));
						}
					}
				}

				string enrolledCoursesQuery = "SELECT CourseCode FROM Students WHERE StudentID = @StudentID";
				HashSet<string> enrolledCourses = new HashSet<string>();

				using (SqlCommand cmd = new SqlCommand(enrolledCoursesQuery, conn))
				{
					cmd.Parameters.AddWithValue("@StudentID", studentID);
					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						if (reader.Read())
						{
							string courseCodes = reader["CourseCode"].ToString();
							if (!string.IsNullOrEmpty(courseCodes))
							{
								enrolledCourses = new HashSet<string>(courseCodes.Split(',').Select(code => code.Trim()));
							}
						}
					}
				}

				var courseGroups = courses.GroupBy(c => c.CourseName);
				List<Course> availableCourses = new List<Course>();

				foreach (var group in courseGroups)
				{
					foreach (var course in group.OrderBy(c => c.GroupNumber))
					{
						if (!enrolledCourses.Any(ec => ec.StartsWith(course.CourseCode.Split('.')[0])) && !IsCourseFull(course.CourseCode))
						{
							availableCourses.Add(course);
							break;
						}
					}
				}

				comBox_enrolllist.Items.Clear();
				comBox_enrolllist.SelectedIndex = -1; // Set the ComboBox to blank initially

				foreach (var course in availableCourses)
				{
					if (!enrolledCourses.Contains(course.CourseCode))
					{
						comBox_enrolllist.Items.Add(course);
					}
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show($"Error loading courses: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}

	private bool IsGroupFull(SqlConnection conn, string courseCode)
	{
		string query = $"SELECT COUNT(*) FROM [{courseCode}]";
		using (SqlCommand cmd = new SqlCommand(query, conn))
		{
			int studentCount = (int)cmd.ExecuteScalar();
			return studentCount >= 5;
		}
	}

	private void btn_Enroll_Click(object sender, EventArgs e)
	{
		if (comBox_enrolllist.SelectedItem is Course selectedCourse)
		{
			string courseCode = selectedCourse.CourseCode;

			if (IsAlreadyEnrolledInCourse(courseCode))
			{
				MessageBox.Show("You are already enrolled in this course.", "Enrollment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (IsCourseFull(courseCode))
			{
				MessageBox.Show("This course is already full.", "Course Full", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			EnrollStudentInCourse(courseCode);
		}
		else
		{
			MessageBox.Show("Please select a valid course to enroll.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}

	private bool IsAlreadyEnrolledInCourse(string courseCode)
	{
		try
		{
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				conn.Open();
				string baseCourseCode = courseCode.Split('.')[0];

				string query = "SELECT COUNT(*) FROM Students WHERE StudentID = @StudentID AND CourseCode LIKE @BaseCourseCode + '.%'";
				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					cmd.Parameters.AddWithValue("@StudentID", studentID);
					cmd.Parameters.AddWithValue("@BaseCourseCode", baseCourseCode);
					int count = (int)cmd.ExecuteScalar();
					return count > 0;
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show($"Error checking enrollment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return false;
		}
	}

	private bool IsCourseFull(string courseCode)
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
					return studentCount >= 5;
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show($"Error checking course capacity: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return true;
		}
	}

	private void EnrollStudentInCourse(string courseCode)
	{
		try
		{
			string fullName = string.Empty;
			string phoneNumber = string.Empty;
			string programCode = string.Empty;

			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				conn.Open();

				string studentQuery = "SELECT FullName, PhoneNumber, ProgramCode FROM Students WHERE StudentID = @StudentID";
				using (SqlCommand studentCmd = new SqlCommand(studentQuery, conn))
				{
					studentCmd.Parameters.AddWithValue("@StudentID", studentID);
					using (SqlDataReader reader = studentCmd.ExecuteReader())
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

				string enrollQuery = $"INSERT INTO [{courseCode}] (StudentID, FullName, PhoneNumber, ProgramCode) VALUES (@StudentID, @FullName, @PhoneNumber, @ProgramCode)";
				using (SqlCommand enrollCmd = new SqlCommand(enrollQuery, conn))
				{
					enrollCmd.Parameters.AddWithValue("@StudentID", studentID);
					enrollCmd.Parameters.AddWithValue("@FullName", fullName);
					enrollCmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
					enrollCmd.Parameters.AddWithValue("@ProgramCode", programCode);
					enrollCmd.ExecuteNonQuery();
				}

				string updateQuery = "UPDATE Students SET CourseCode = CASE WHEN CourseCode IS NULL OR CourseCode = '' THEN @CourseCode ELSE CourseCode + ', ' + @CourseCode END WHERE StudentID = @StudentID";
				using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
				{
					updateCmd.Parameters.AddWithValue("@CourseCode", courseCode);
					updateCmd.Parameters.AddWithValue("@StudentID", studentID);
					updateCmd.ExecuteNonQuery();
				}
			}

			MessageBox.Show($"You have successfully enrolled in {courseCode}.", "Enrollment Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

			LoadAvailableCourses();
			combox_enrolllist.SelectedIndex = -1; // Set the ComboBox to blank
		}
		catch (Exception ex)
		{
			MessageBox.Show($"Error enrolling in course: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
