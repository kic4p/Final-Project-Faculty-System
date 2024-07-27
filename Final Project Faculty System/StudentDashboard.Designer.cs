namespace Final_Project_Faculty_System
{
	partial class StudentDashboard
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDashboard));
			pictureBox1 = new PictureBox();
			picBox_unisel = new PictureBox();
			panel_title = new Panel();
			btn_logout_student = new Button();
			btn_logout = new Button();
			lbl_student_fullName = new Label();
			comBox_enrolllist = new ComboBox();
			btn_enroll = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)picBox_unisel).BeginInit();
			panel_title.SuspendLayout();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(199, 11);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(168, 76);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 2;
			pictureBox1.TabStop = false;
			// 
			// picBox_unisel
			// 
			picBox_unisel.Image = (Image)resources.GetObject("picBox_unisel.Image");
			picBox_unisel.Location = new Point(30, 15);
			picBox_unisel.Name = "picBox_unisel";
			picBox_unisel.Size = new Size(139, 65);
			picBox_unisel.SizeMode = PictureBoxSizeMode.Zoom;
			picBox_unisel.TabIndex = 1;
			picBox_unisel.TabStop = false;
			// 
			// panel_title
			// 
			panel_title.BackColor = Color.White;
			panel_title.Controls.Add(btn_logout);
			panel_title.Controls.Add(pictureBox1);
			panel_title.Controls.Add(picBox_unisel);
			panel_title.Dock = DockStyle.Top;
			panel_title.Font = new Font("Source Sans 3", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			panel_title.Location = new Point(0, 0);
			panel_title.Name = "panel_title";
			panel_title.Size = new Size(387, 101);
			panel_title.TabIndex = 1;
			// 
			// btn_logout_student
			// 
			btn_logout_student.BackColor = Color.Red;
			btn_logout_student.Font = new Font("Source Sans 3", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btn_logout_student.ForeColor = Color.White;
			btn_logout_student.Location = new Point(281, 107);
			btn_logout_student.Name = "btn_logout_student";
			btn_logout_student.Size = new Size(94, 29);
			btn_logout_student.TabIndex = 6;
			btn_logout_student.Text = "Logout";
			btn_logout_student.UseVisualStyleBackColor = false;
			btn_logout_student.Click += btn_logout_student_Click;
			// 
			// btn_logout
			// 
			btn_logout.BackColor = Color.Red;
			btn_logout.Font = new Font("Source Sans 3", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btn_logout.ForeColor = Color.White;
			btn_logout.Location = new Point(1126, 11);
			btn_logout.Name = "btn_logout";
			btn_logout.Size = new Size(94, 26);
			btn_logout.TabIndex = 4;
			btn_logout.Text = "Logout";
			btn_logout.UseVisualStyleBackColor = false;
			// 
			// lbl_student_fullName
			// 
			lbl_student_fullName.AutoSize = true;
			lbl_student_fullName.Font = new Font("Source Sans 3", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lbl_student_fullName.Location = new Point(12, 152);
			lbl_student_fullName.Name = "lbl_student_fullName";
			lbl_student_fullName.Size = new Size(97, 28);
			lbl_student_fullName.TabIndex = 3;
			lbl_student_fullName.Text = "Student:";
			// 
			// comBox_enrolllist
			// 
			comBox_enrolllist.FormattingEnabled = true;
			comBox_enrolllist.Location = new Point(50, 209);
			comBox_enrolllist.Name = "comBox_enrolllist";
			comBox_enrolllist.Size = new Size(286, 26);
			comBox_enrolllist.TabIndex = 4;
			// 
			// btn_enroll
			// 
			btn_enroll.BackColor = Color.Black;
			btn_enroll.Font = new Font("Source Sans 3 Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btn_enroll.ForeColor = Color.White;
			btn_enroll.Location = new Point(106, 267);
			btn_enroll.Name = "btn_enroll";
			btn_enroll.Size = new Size(148, 29);
			btn_enroll.TabIndex = 5;
			btn_enroll.Text = "Enroll Course";
			btn_enroll.UseVisualStyleBackColor = false;
			btn_enroll.Click += btn_Enroll_Click;
			// 
			// StudentDashboard
			// 
			AutoScaleDimensions = new SizeF(8F, 18F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(387, 326);
			Controls.Add(btn_logout_student);
			Controls.Add(btn_enroll);
			Controls.Add(comBox_enrolllist);
			Controls.Add(lbl_student_fullName);
			Controls.Add(panel_title);
			Font = new Font("Source Sans 3", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Name = "StudentDashboard";
			Text = "Course Registration";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)picBox_unisel).EndInit();
			panel_title.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private PictureBox picBox_unisel;
		private Panel panel_title;
		private Button btn_logout;
		private Label lbl_student_fullName;
		private ComboBox comBox_enrolllist;
		private Button btn_enroll;
		private Button btn_logout_student;
	}
}