namespace Final_Project_Faculty_System
{
	partial class CourseRegister
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseRegister));
			pictureBox1 = new PictureBox();
			picBox_unisel = new PictureBox();
			btn_logout = new Button();
			lbl_title_courseRegister = new Label();
			lbl_student_fullName = new Label();
			comBox_enrolllist = new ComboBox();
			btn_enroll = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)picBox_unisel).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(181, 7);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(168, 85);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 4;
			pictureBox1.TabStop = false;
			// 
			// picBox_unisel
			// 
			picBox_unisel.Image = (Image)resources.GetObject("picBox_unisel.Image");
			picBox_unisel.Location = new Point(12, 12);
			picBox_unisel.Name = "picBox_unisel";
			picBox_unisel.Size = new Size(139, 72);
			picBox_unisel.SizeMode = PictureBoxSizeMode.Zoom;
			picBox_unisel.TabIndex = 3;
			picBox_unisel.TabStop = false;
			// 
			// btn_logout
			// 
			btn_logout.BackColor = Color.Red;
			btn_logout.Font = new Font("Source Sans 3", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btn_logout.ForeColor = Color.White;
			btn_logout.Location = new Point(374, 7);
			btn_logout.Name = "btn_logout";
			btn_logout.Size = new Size(94, 29);
			btn_logout.TabIndex = 5;
			btn_logout.Text = "Logout";
			btn_logout.UseVisualStyleBackColor = false;
			btn_logout.Click += btn_logout_student_Click;
			// 
			// lbl_title_courseRegister
			// 
			lbl_title_courseRegister.AutoSize = true;
			lbl_title_courseRegister.Font = new Font("Source Sans 3 Medium", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_title_courseRegister.Location = new Point(69, 110);
			lbl_title_courseRegister.Name = "lbl_title_courseRegister";
			lbl_title_courseRegister.Size = new Size(321, 45);
			lbl_title_courseRegister.TabIndex = 6;
			lbl_title_courseRegister.Text = "Course Registration";
			// 
			// lbl_student_fullName
			// 
			lbl_student_fullName.AutoSize = true;
			lbl_student_fullName.Font = new Font("Source Sans 3", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lbl_student_fullName.Location = new Point(12, 165);
			lbl_student_fullName.Name = "lbl_student_fullName";
			lbl_student_fullName.Size = new Size(97, 28);
			lbl_student_fullName.TabIndex = 7;
			lbl_student_fullName.Text = "Student:";
			// 
			// comBox_enrolllist
			// 
			comBox_enrolllist.Font = new Font("Source Sans 3", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			comBox_enrolllist.FormattingEnabled = true;
			comBox_enrolllist.Location = new Point(24, 234);
			comBox_enrolllist.Name = "comBox_enrolllist";
			comBox_enrolllist.Size = new Size(408, 26);
			comBox_enrolllist.TabIndex = 8;
			// 
			// btn_enroll
			// 
			btn_enroll.BackColor = Color.Black;
			btn_enroll.ForeColor = Color.White;
			btn_enroll.Location = new Point(168, 349);
			btn_enroll.Name = "btn_enroll";
			btn_enroll.Size = new Size(123, 40);
			btn_enroll.TabIndex = 9;
			btn_enroll.Text = "Enroll";
			btn_enroll.UseVisualStyleBackColor = false;
			btn_enroll.Click += btn_Enroll_Click;
			// 
			// CourseRegister
			// 
			AutoScaleDimensions = new SizeF(9F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(480, 582);
			Controls.Add(btn_enroll);
			Controls.Add(comBox_enrolllist);
			Controls.Add(lbl_student_fullName);
			Controls.Add(lbl_title_courseRegister);
			Controls.Add(btn_logout);
			Controls.Add(pictureBox1);
			Controls.Add(picBox_unisel);
			Font = new Font("Source Sans 3 Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			Name = "CourseRegister";
			Text = "Student Course Register";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)picBox_unisel).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private PictureBox picBox_unisel;
		private Button btn_logout;
		private Label lbl_title_courseRegister;
		private Label lbl_student_fullName;
		private ComboBox comBox_enrolllist;
		private Button btn_enroll;
	}
}