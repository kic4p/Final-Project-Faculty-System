using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace Final_Project_Faculty_System
{
	public partial class StudentLogin : Form
	{
		private System.Windows.Forms.TextBox txt_studentID;
		private string connectionString = @"Server=.\SQLEXPRESS;Database=Faculty System;Trusted_Connection=True;TrustServerCertificate=True;";

		public StudentLogin()
		{
			InitializeComponent();
		}

		private void btn_lecturer_Click(object sender, EventArgs e)
		{
			// Hide the StudentLogin form
			this.Hide();

			// Show the Form1 (Login form)
			Form1 loginForm = new Form1();
			loginForm.Show();
		}

		private void btn_login_Click(object sender, EventArgs e)
		{
			// Use the correct TextBox control for the student ID input
			string studentID = txt_studentID.Text;

			if (string.IsNullOrWhiteSpace(studentID))
			{
				MessageBox.Show("Please enter your Student ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();
					string query = "SELECT COUNT(*) FROM Students WHERE StudentID = @StudentID";
					using (SqlCommand cmd = new SqlCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("@StudentID", studentID);
						int count = (int)cmd.ExecuteScalar();

						if (count > 0)
						{
							// Hide the StudentLogin form
							this.Hide();

							// Show the StudentDashboard form
							StudentDashboard studentDashboard = new StudentDashboard(studentID);
							studentDashboard.Show();
						}
						else
						{
							MessageBox.Show("Invalid Student ID. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_register_Click(object sender, EventArgs e)
		{
			// Show the RegisterStudent form
			RegisterStudent registerForm = new RegisterStudent();
			registerForm.Show();
		}
	}
}
