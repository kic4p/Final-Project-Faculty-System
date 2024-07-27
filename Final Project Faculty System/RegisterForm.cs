using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace Final_Project_Faculty_System
{
	public partial class RegisterForm : Form
	{
		private string connectionString = @"Server=.\SQLEXPRESS;Database=Faculty System;Trusted_Connection=True;TrustServerCertificate=True;";

		public RegisterForm()
		{
			InitializeComponent();
		}

		private void RegisterForm_Load(object sender, EventArgs e)
		{
			// Any initialization code if needed
		}

		private void btn_Register_Click(object sender, EventArgs e)
		{
			string username = txtBox_register_username.Text.Trim();
			string password = txtBox_password.Text.Trim();
			string fullName = txtBox_FullName.Text.Trim();

			if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(fullName))
			{
				MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (RegisterUser(username, password, fullName))
			{
				MessageBox.Show("Registration successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close(); // Close the registration form
			}
			else
			{
				MessageBox.Show("Registration failed. The username may already be taken.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private bool RegisterUser(string username, string password, string fullName)
		{
			try
			{
				string query = "INSERT INTO Lecturers (Username, Password, FullName) VALUES (@Username, @Password, @FullName)";
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					SqlCommand cmd = new SqlCommand(query, conn);
					cmd.Parameters.AddWithValue("@Username", username);
					cmd.Parameters.AddWithValue("@Password", password);
					cmd.Parameters.AddWithValue("@FullName", fullName);
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