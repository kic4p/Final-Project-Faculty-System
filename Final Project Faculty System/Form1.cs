using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace Final_Project_Faculty_System
{
	public partial class Form1 : Form
	{
		private string connectionString = @"Server=.\SQLEXPRESS;Database=Faculty System;Trusted_Connection=True;TrustServerCertificate=True;";

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btn_login_Click(object sender, EventArgs e)
		{
			string username = txtBox_username.Text;
			string password = txtBox_password.Text;

			// Assuming IsValidUser returns a boolean and also retrieves the full name
			string fullName;
			if (IsValidUser(username, password, out fullName))
			{
				this.Hide();
				LecturerDashboard dashboard = new LecturerDashboard(fullName);
				dashboard.Show();
			}
			else
			{
				MessageBox.Show("Invalid username or password.");
			}
		}

		private bool IsValidUser(string username, string password, out string fullName)
		{
			fullName = string.Empty; // Default value
			string query = "SELECT FullName FROM Lecturers WHERE Username=@Username AND Password=@Password";
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				SqlCommand cmd = new SqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@Username", username);
				cmd.Parameters.AddWithValue("@Password", password);
				conn.Open();
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows && reader.Read())
				{
					fullName = reader["FullName"].ToString();
					return true;
				}
			}
			return false;
		}

		private void btnRegister_Click(object sender, EventArgs e)
		{
			RegisterForm registerForm = new RegisterForm();
			registerForm.Show();
		}

		private void btn_student_Click(object sender, EventArgs e)
		{
			// Instantiate the StudentDashboard form without any parameters
			StudentLogin studentLogin = new StudentLogin();

			// Show the StudentDashboard form
			studentLogin.Show();

			// Hide the current login form
			this.Hide();
		}


	}
}
