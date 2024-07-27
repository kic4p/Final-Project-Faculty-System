namespace Final_Project_Faculty_System
{
	partial class StudentLogin
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btn_lecturer = new Button();
			btn_register = new Button();
			btn_login = new Button();
			lbl_studentID = new Label();
			lbl_title_login = new Label();
			txt_studentID = new TextBox();
			SuspendLayout();
			// 
			// btn_lecturer
			// 
			btn_lecturer.Font = new Font("Source Sans 3", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btn_lecturer.Location = new Point(100, 13);
			btn_lecturer.Name = "btn_lecturer";
			btn_lecturer.Size = new Size(178, 32);
			btn_lecturer.TabIndex = 9;
			btn_lecturer.Text = "Click here if lecturer";
			btn_lecturer.UseVisualStyleBackColor = true;
			btn_lecturer.Click += btn_lecturer_Click;
			// 
			// btn_register
			// 
			btn_register.Location = new Point(108, 296);
			btn_register.Name = "btn_register";
			btn_register.Size = new Size(161, 39);
			btn_register.TabIndex = 16;
			btn_register.Text = "Register";
			btn_register.UseVisualStyleBackColor = true;
			btn_register.Click += btn_register_Click;
			// 
			// btn_login
			// 
			btn_login.BackColor = Color.Black;
			btn_login.ForeColor = SystemColors.Control;
			btn_login.Location = new Point(108, 238);
			btn_login.Name = "btn_login";
			btn_login.Size = new Size(161, 39);
			btn_login.TabIndex = 15;
			btn_login.Text = "Login";
			btn_login.UseVisualStyleBackColor = false;
			btn_login.Click += btn_login_Click;
			// 
			// lbl_studentID
			// 
			lbl_studentID.AutoSize = true;
			lbl_studentID.Location = new Point(25, 185);
			lbl_studentID.Name = "lbl_studentID";
			lbl_studentID.Size = new Size(82, 20);
			lbl_studentID.TabIndex = 11;
			lbl_studentID.Text = "Student ID:";
			// 
			// lbl_title_login
			// 
			lbl_title_login.AutoSize = true;
			lbl_title_login.Font = new Font("Source Sans 3 Medium", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_title_login.Location = new Point(128, 58);
			lbl_title_login.Name = "lbl_title_login";
			lbl_title_login.Size = new Size(106, 45);
			lbl_title_login.TabIndex = 10;
			lbl_title_login.Text = "Login";
			// 
			// txt_studentID
			// 
			txt_studentID.Location = new Point(113, 178);
			txt_studentID.Name = "txt_studentID";
			txt_studentID.Size = new Size(217, 27);
			txt_studentID.TabIndex = 0;
			// 
			// StudentLogin
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(379, 450);
			Controls.Add(txt_studentID);
			Controls.Add(btn_register);
			Controls.Add(btn_login);
			Controls.Add(lbl_studentID);
			Controls.Add(lbl_title_login);
			Controls.Add(btn_lecturer);
			Name = "StudentLogin";
			Text = "Student Login";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btn_lecturer;
		private Button btn_register;
		private Button btn_login;
		private Label lbl_studentID;
		private Label lbl_title_login;
	}
}