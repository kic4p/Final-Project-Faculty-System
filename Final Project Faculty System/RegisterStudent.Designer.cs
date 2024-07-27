namespace Final_Project_Faculty_System
{
	partial class RegisterStudent
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
			btn_Cancel = new Button();
			btn_Register = new Button();
			txtBox_phone = new TextBox();
			lbl_student_phone = new Label();
			txtBox_student_fullName = new TextBox();
			lbl_student_fullName = new Label();
			txtBox_register_studentID = new TextBox();
			txtBox_username = new Label();
			lbl_title = new Label();
			lbl_student_program = new Label();
			comBox_program = new ComboBox();
			SuspendLayout();
			// 
			// btn_Cancel
			// 
			btn_Cancel.BackColor = Color.Red;
			btn_Cancel.Font = new Font("Source Sans 3 Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btn_Cancel.ForeColor = Color.White;
			btn_Cancel.Location = new Point(656, 12);
			btn_Cancel.Name = "btn_Cancel";
			btn_Cancel.Size = new Size(132, 40);
			btn_Cancel.TabIndex = 17;
			btn_Cancel.Text = "Cancel";
			btn_Cancel.UseVisualStyleBackColor = false;
			btn_Cancel.Click += btn_Cancel_Click;
			// 
			// btn_Register
			// 
			btn_Register.BackColor = Color.Black;
			btn_Register.Font = new Font("Source Sans 3 Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btn_Register.ForeColor = Color.White;
			btn_Register.Location = new Point(357, 357);
			btn_Register.Name = "btn_Register";
			btn_Register.Size = new Size(132, 40);
			btn_Register.TabIndex = 16;
			btn_Register.Text = "Register";
			btn_Register.UseVisualStyleBackColor = false;
			btn_Register.Click += btn_Register_Click;
			// 
			// txtBox_phone
			// 
			txtBox_phone.Location = new Point(198, 226);
			txtBox_phone.Name = "txtBox_phone";
			txtBox_phone.Size = new Size(481, 27);
			txtBox_phone.TabIndex = 15;
			// 
			// lbl_student_phone
			// 
			lbl_student_phone.AutoSize = true;
			lbl_student_phone.Font = new Font("Source Sans 3 Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_student_phone.Location = new Point(70, 233);
			lbl_student_phone.Name = "lbl_student_phone";
			lbl_student_phone.Size = new Size(122, 20);
			lbl_student_phone.TabIndex = 14;
			lbl_student_phone.Text = "Phone Number:";
			// 
			// txtBox_student_fullName
			// 
			txtBox_student_fullName.Location = new Point(198, 166);
			txtBox_student_fullName.Name = "txtBox_student_fullName";
			txtBox_student_fullName.Size = new Size(481, 27);
			txtBox_student_fullName.TabIndex = 13;
			// 
			// lbl_student_fullName
			// 
			lbl_student_fullName.AutoSize = true;
			lbl_student_fullName.Font = new Font("Source Sans 3 Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_student_fullName.Location = new Point(105, 173);
			lbl_student_fullName.Name = "lbl_student_fullName";
			lbl_student_fullName.Size = new Size(89, 20);
			lbl_student_fullName.TabIndex = 12;
			lbl_student_fullName.Text = "Full Name:";
			// 
			// txtBox_register_studentID
			// 
			txtBox_register_studentID.Location = new Point(198, 112);
			txtBox_register_studentID.Name = "txtBox_register_studentID";
			txtBox_register_studentID.Size = new Size(481, 27);
			txtBox_register_studentID.TabIndex = 11;
			// 
			// txtBox_username
			// 
			txtBox_username.AutoSize = true;
			txtBox_username.Font = new Font("Source Sans 3 Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			txtBox_username.Location = new Point(102, 119);
			txtBox_username.Name = "txtBox_username";
			txtBox_username.Size = new Size(90, 20);
			txtBox_username.TabIndex = 10;
			txtBox_username.Text = "Student ID:";
			// 
			// lbl_title
			// 
			lbl_title.AutoSize = true;
			lbl_title.Font = new Font("Source Sans 3 Medium", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_title.Location = new Point(227, 25);
			lbl_title.Name = "lbl_title";
			lbl_title.Size = new Size(336, 45);
			lbl_title.TabIndex = 9;
			lbl_title.Text = "Student Registration";
			// 
			// lbl_student_program
			// 
			lbl_student_program.AutoSize = true;
			lbl_student_program.Font = new Font("Source Sans 3 Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_student_program.Location = new Point(115, 295);
			lbl_student_program.Name = "lbl_student_program";
			lbl_student_program.Size = new Size(77, 20);
			lbl_student_program.TabIndex = 18;
			lbl_student_program.Text = "Program:";
			// 
			// comBox_program
			// 
			comBox_program.FormattingEnabled = true;
			comBox_program.Location = new Point(198, 287);
			comBox_program.Name = "comBox_program";
			comBox_program.Size = new Size(481, 28);
			comBox_program.TabIndex = 19;
			// 
			// RegisterStudent
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(comBox_program);
			Controls.Add(lbl_student_program);
			Controls.Add(btn_Cancel);
			Controls.Add(btn_Register);
			Controls.Add(txtBox_phone);
			Controls.Add(lbl_student_phone);
			Controls.Add(txtBox_student_fullName);
			Controls.Add(lbl_student_fullName);
			Controls.Add(txtBox_register_studentID);
			Controls.Add(txtBox_username);
			Controls.Add(lbl_title);
			Name = "RegisterStudent";
			Text = "Student Registration";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btn_Cancel;
		private Button btn_Register;
		private TextBox txtBox_phone;
		private Label lbl_student_phone;
		private TextBox txtBox_student_fullName;
		private Label lbl_student_fullName;
		private TextBox txtBox_register_studentID;
		private Label txtBox_username;
		private Label lbl_title;
		private Label lbl_student_program;
		private ComboBox comBox_program;
	}
}