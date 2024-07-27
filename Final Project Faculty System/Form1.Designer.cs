namespace Final_Project_Faculty_System
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			lbl_title_login = new Label();
			lbl_username = new Label();
			txtBox_username = new TextBox();
			txtBox_password = new TextBox();
			lbl_password = new Label();
			btn_login = new Button();
			btn_register = new Button();
			btn_student = new Button();
			SuspendLayout();
			// 
			// lbl_title_login
			// 
			lbl_title_login.AutoSize = true;
			lbl_title_login.Font = new Font("Source Sans 3 Medium", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_title_login.Location = new Point(127, 60);
			lbl_title_login.Name = "lbl_title_login";
			lbl_title_login.Size = new Size(106, 45);
			lbl_title_login.TabIndex = 0;
			lbl_title_login.Text = "Login";
			// 
			// lbl_username
			// 
			lbl_username.AutoSize = true;
			lbl_username.Location = new Point(33, 154);
			lbl_username.Name = "lbl_username";
			lbl_username.Size = new Size(88, 20);
			lbl_username.TabIndex = 1;
			lbl_username.Text = "Username:";
			// 
			// txtBox_username
			// 
			txtBox_username.Location = new Point(127, 151);
			txtBox_username.Name = "txtBox_username";
			txtBox_username.Size = new Size(217, 27);
			txtBox_username.TabIndex = 3;
			// 
			// txtBox_password
			// 
			txtBox_password.Location = new Point(127, 221);
			txtBox_password.Name = "txtBox_password";
			txtBox_password.Size = new Size(217, 27);
			txtBox_password.TabIndex = 5;
			txtBox_password.UseSystemPasswordChar = true;
			// 
			// lbl_password
			// 
			lbl_password.AutoSize = true;
			lbl_password.Location = new Point(33, 224);
			lbl_password.Name = "lbl_password";
			lbl_password.Size = new Size(82, 20);
			lbl_password.TabIndex = 4;
			lbl_password.Text = "Password:";
			// 
			// btn_login
			// 
			btn_login.BackColor = Color.Black;
			btn_login.ForeColor = SystemColors.Control;
			btn_login.Location = new Point(113, 297);
			btn_login.Name = "btn_login";
			btn_login.Size = new Size(161, 39);
			btn_login.TabIndex = 6;
			btn_login.Text = "Login";
			btn_login.UseVisualStyleBackColor = false;
			btn_login.Click += btn_login_Click;
			// 
			// btn_register
			// 
			btn_register.Location = new Point(113, 355);
			btn_register.Name = "btn_register";
			btn_register.Size = new Size(161, 39);
			btn_register.TabIndex = 7;
			btn_register.Text = "Register";
			btn_register.UseVisualStyleBackColor = true;
			btn_register.Click += btnRegister_Click;
			// 
			// btn_student
			// 
			btn_student.Font = new Font("Source Sans 3", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btn_student.Location = new Point(108, 11);
			btn_student.Name = "btn_student";
			btn_student.Size = new Size(178, 32);
			btn_student.TabIndex = 8;
			btn_student.Text = "Click here if student";
			btn_student.UseVisualStyleBackColor = true;
			btn_student.Click += btn_student_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(9F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(379, 450);
			Controls.Add(btn_student);
			Controls.Add(btn_register);
			Controls.Add(btn_login);
			Controls.Add(txtBox_password);
			Controls.Add(lbl_password);
			Controls.Add(txtBox_username);
			Controls.Add(lbl_username);
			Controls.Add(lbl_title_login);
			Font = new Font("Source Sans 3 Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lbl_title_login;
		private Label lbl_username;
		private TextBox txtBox_username;
		private TextBox txtBox_password;
		private Label lbl_password;
		private Button btn_login;
		private Button btn_register;
		private Button btn_student;
	}
}
