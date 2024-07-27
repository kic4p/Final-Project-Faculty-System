namespace Final_Project_Faculty_System
{
	partial class RegisterForm
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
			lbl_title = new Label();
			txtBox_username = new Label();
			txtBox_register_username = new TextBox();
			txtBox_password = new TextBox();
			lbl_password = new Label();
			txtBox_FullName = new TextBox();
			lbl_FullName = new Label();
			btn_Register = new Button();
			btn_Cancel = new Button();
			SuspendLayout();
			// 
			// lbl_title
			// 
			lbl_title.AutoSize = true;
			lbl_title.Font = new Font("Source Sans 3 Medium", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_title.Location = new Point(227, 25);
			lbl_title.Name = "lbl_title";
			lbl_title.Size = new Size(344, 45);
			lbl_title.TabIndex = 0;
			lbl_title.Text = "Lecturer Registration";
			// 
			// txtBox_username
			// 
			txtBox_username.AutoSize = true;
			txtBox_username.Font = new Font("Source Sans 3 Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			txtBox_username.Location = new Point(104, 121);
			txtBox_username.Name = "txtBox_username";
			txtBox_username.Size = new Size(88, 20);
			txtBox_username.TabIndex = 1;
			txtBox_username.Text = "Username:";
			// 
			// txtBox_register_username
			// 
			txtBox_register_username.Location = new Point(198, 112);
			txtBox_register_username.Name = "txtBox_register_username";
			txtBox_register_username.Size = new Size(481, 29);
			txtBox_register_username.TabIndex = 2;
			// 
			// txtBox_password
			// 
			txtBox_password.Location = new Point(198, 166);
			txtBox_password.Name = "txtBox_password";
			txtBox_password.Size = new Size(481, 29);
			txtBox_password.TabIndex = 4;
			txtBox_password.UseSystemPasswordChar = true;
			// 
			// lbl_password
			// 
			lbl_password.AutoSize = true;
			lbl_password.Font = new Font("Source Sans 3 Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_password.Location = new Point(104, 175);
			lbl_password.Name = "lbl_password";
			lbl_password.Size = new Size(82, 20);
			lbl_password.TabIndex = 3;
			lbl_password.Text = "Password:";
			// 
			// txtBox_FullName
			// 
			txtBox_FullName.Location = new Point(198, 226);
			txtBox_FullName.Name = "txtBox_FullName";
			txtBox_FullName.Size = new Size(481, 29);
			txtBox_FullName.TabIndex = 6;
			// 
			// lbl_FullName
			// 
			lbl_FullName.AutoSize = true;
			lbl_FullName.Font = new Font("Source Sans 3 Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_FullName.Location = new Point(104, 235);
			lbl_FullName.Name = "lbl_FullName";
			lbl_FullName.Size = new Size(89, 20);
			lbl_FullName.TabIndex = 5;
			lbl_FullName.Text = "Full Name:";
			// 
			// btn_Register
			// 
			btn_Register.BackColor = Color.Black;
			btn_Register.Font = new Font("Source Sans 3 Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btn_Register.ForeColor = Color.White;
			btn_Register.Location = new Point(357, 314);
			btn_Register.Name = "btn_Register";
			btn_Register.Size = new Size(132, 40);
			btn_Register.TabIndex = 7;
			btn_Register.Text = "Register";
			btn_Register.UseVisualStyleBackColor = false;
			btn_Register.Click += btn_Register_Click;
			// 
			// btn_Cancel
			// 
			btn_Cancel.BackColor = Color.Red;
			btn_Cancel.Font = new Font("Source Sans 3 Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btn_Cancel.ForeColor = Color.White;
			btn_Cancel.Location = new Point(656, 12);
			btn_Cancel.Name = "btn_Cancel";
			btn_Cancel.Size = new Size(132, 40);
			btn_Cancel.TabIndex = 8;
			btn_Cancel.Text = "Cancel";
			btn_Cancel.UseVisualStyleBackColor = false;
			btn_Cancel.Click += btn_Cancel_Click;
			// 
			// RegisterForm
			// 
			AutoScaleDimensions = new SizeF(8F, 18F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(800, 405);
			Controls.Add(btn_Cancel);
			Controls.Add(btn_Register);
			Controls.Add(txtBox_FullName);
			Controls.Add(lbl_FullName);
			Controls.Add(txtBox_password);
			Controls.Add(lbl_password);
			Controls.Add(txtBox_register_username);
			Controls.Add(txtBox_username);
			Controls.Add(lbl_title);
			Font = new Font("Source Sans 3", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Name = "RegisterForm";
			Text = "RegisterForm";
			Load += RegisterForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lbl_title;
		private Label txtBox_username;
		private TextBox txtBox_register_username;
		private TextBox txtBox_password;
		private Label lbl_password;
		private TextBox txtBox_FullName;
		private Label lbl_FullName;
		private Button btn_Register;
		private Button btn_Cancel;
	}
}