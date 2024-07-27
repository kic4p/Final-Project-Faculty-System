using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Final_Project_Faculty_System
{
	public partial class RegisterStudent : Form
	{
		private string connectionString = @"Server=.\SQLEXPRESS;Database=Faculty System;Trusted_Connection=True;TrustServerCertificate=True;";

		public RegisterStudent()
		{
			InitializeComponent();
			LoadPrograms();
		}

		private void LoadPrograms()
		{
			// Clear existing items
			comBox_program.Items.Clear();

			// Add the program codes and names to the combo box
			var programs = new[]
			{
				"IT301 – Diploma in Information Technology",
				"IT302 – Diploma Computer Science (Industrial Computing)",
				"IT401 – Bachelor in Information Technology (Hons)",
				"IT402 – Bachelor of Software Engineering (Hons)",
				"IT403 – Bachelor of Computer Science (Hons)",
				"IT405 – Bachelor of Multimedia Industry (Hons)",
				"BT402 – Bachelor of Bioinformatics (Hons)"
			};

			comBox_program.Items.AddRange(programs);

		}

		private void btn_Register_Click(object sender, EventArgs e)
		{
			string studentID = txtBox_register_studentID.Text.Trim();
			string fullName = txtBox_student_fullName.Text.Trim();
			string phoneNumber = txtBox_phone.Text.Trim();
			string program = comBox_program.SelectedItem?.ToString();

			if (string.IsNullOrEmpty(studentID) || string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(program))
			{
				MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// Ensure StudentID is exactly 4 digits
			if (studentID.Length != 4 || !long.TryParse(studentID, out _))
			{
				MessageBox.Show("Student ID must be exactly 4 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// Ensure full name contains only valid characters
			if (!Regex.IsMatch(fullName, @"^[a-zA-Z\s/'-]+$"))
			{
				MessageBox.Show("Full Name can only contain letters, spaces, apostrophes, and slashes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// Ensure the phone number contains only digits and has 10-11 digits
			if (phoneNumber.Length < 10 || phoneNumber.Length > 11 || !long.TryParse(phoneNumber, out _))
			{
				MessageBox.Show("Please enter a valid 10-11 digit phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// Prefix the phone number with '6'
			string fullPhoneNumber = "6" + phoneNumber;

			// Prefix the student ID
			string fullStudentID = "422300" + studentID;

			// Check for duplicate StudentID
			if (IsStudentIDExists(fullStudentID))
			{
				MessageBox.Show("This Student ID is already registered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// Check for duplicate Phone Number
			if (IsPhoneNumberExists(fullPhoneNumber))
			{
				MessageBox.Show("This phone number is already registered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// Extract program code
			string programCode = program.Split(' ')[0];

			if (RegisterNewStudent(fullStudentID, fullName, fullPhoneNumber, programCode))
			{
				MessageBox.Show("Registration successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close(); // Close the registration form
			}
			else
			{
				MessageBox.Show("Registration failed. The student ID may already be taken.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private bool IsStudentIDExists(string studentID)
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					string query = "SELECT COUNT(*) FROM Students WHERE StudentID = @StudentID";
					SqlCommand cmd = new SqlCommand(query, conn);
					cmd.Parameters.AddWithValue("@StudentID", studentID);
					conn.Open();
					int count = (int)cmd.ExecuteScalar();
					return count > 0;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
				return false;
			}
		}

		private bool IsPhoneNumberExists(string phoneNumber)
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					string query = "SELECT COUNT(*) FROM Students WHERE PhoneNumber = @PhoneNumber";
					SqlCommand cmd = new SqlCommand(query, conn);
					cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
					conn.Open();
					int count = (int)cmd.ExecuteScalar();
					return count > 0;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
				return false;
			}
		}

		private bool RegisterNewStudent(string studentID, string fullName, string phoneNumber, string programCode)
		{
			try
			{
				string query = "INSERT INTO Students (StudentID, FullName, PhoneNumber, ProgramCode) VALUES (@StudentID, @FullName, @PhoneNumber, @ProgramCode)";
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					SqlCommand cmd = new SqlCommand(query, conn);
					cmd.Parameters.AddWithValue("@StudentID", studentID);
					cmd.Parameters.AddWithValue("@FullName", fullName);
					cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
					cmd.Parameters.AddWithValue("@ProgramCode", programCode);
					conn.Open();
					int result = cmd.ExecuteNonQuery();
					return result > 0;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
				return false;
			}
		}

		private void btn_Cancel_Click(object sender, EventArgs e)
		{
			this.Close(); // Close the registration form without saving
		}
	}
}
