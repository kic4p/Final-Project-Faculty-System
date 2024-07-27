namespace Final_Project_Faculty_System
{
	partial class LecturerDashboard
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LecturerDashboard));
			panel_title = new Panel();
			btn_logout = new Button();
			lbl_lecturer_fullName = new Label();
			pictureBox1 = new PictureBox();
			picBox_unisel = new PictureBox();
			label1 = new Label();
			contextMenuStrip1 = new ContextMenuStrip(components);
			tabControl = new TabControl();
			home = new TabPage();
			view_data = new TabPage();
			tabControl2 = new TabControl();
			update_data = new TabPage();
			tabControl1 = new TabControl();
			choose_student = new TabPage();
			btn_choose = new Button();
			lbl_subtitle = new Label();
			lbl_title = new Label();
			comBox_teach = new ComboBox();
			search_phone = new TabPage();
			panelphone = new Panel();
			btn_search = new Button();
			txtbox_phone = new TextBox();
			label3 = new Label();
			lbl_searchtitle = new Label();
			create_course = new TabPage();
			btn_create = new Button();
			panel1 = new Panel();
			radio_g6 = new RadioButton();
			radio_g3 = new RadioButton();
			radio_g5 = new RadioButton();
			radio_g4 = new RadioButton();
			radio_g2 = new RadioButton();
			radio_g1 = new RadioButton();
			lbl_group = new Label();
			lbl_course = new Label();
			comBox_courseList = new ComboBox();
			lbl_title_createcourse = new Label();
			drop_course = new TabPage();
			btn_delete_all = new Button();
			btn_delete_course = new Button();
			comBox_delete = new ComboBox();
			lbl_delete_course = new Label();
			label2 = new Label();
			panel_title.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)picBox_unisel).BeginInit();
			tabControl.SuspendLayout();
			view_data.SuspendLayout();
			update_data.SuspendLayout();
			choose_student.SuspendLayout();
			search_phone.SuspendLayout();
			create_course.SuspendLayout();
			panel1.SuspendLayout();
			drop_course.SuspendLayout();
			SuspendLayout();
			// 
			// panel_title
			// 
			panel_title.BackColor = Color.White;
			panel_title.Controls.Add(btn_logout);
			panel_title.Controls.Add(lbl_lecturer_fullName);
			panel_title.Controls.Add(pictureBox1);
			panel_title.Controls.Add(picBox_unisel);
			panel_title.Controls.Add(label1);
			panel_title.Dock = DockStyle.Top;
			panel_title.Font = new Font("Source Sans 3", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			panel_title.Location = new Point(0, 0);
			panel_title.Name = "panel_title";
			panel_title.Size = new Size(1232, 112);
			panel_title.TabIndex = 0;
			// 
			// btn_logout
			// 
			btn_logout.BackColor = Color.Red;
			btn_logout.Font = new Font("Source Sans 3", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btn_logout.ForeColor = Color.White;
			btn_logout.Location = new Point(1126, 12);
			btn_logout.Name = "btn_logout";
			btn_logout.Size = new Size(94, 29);
			btn_logout.TabIndex = 4;
			btn_logout.Text = "Logout";
			btn_logout.UseVisualStyleBackColor = false;
			btn_logout.Click += btn_logout_Click;
			// 
			// lbl_lecturer_fullName
			// 
			lbl_lecturer_fullName.AutoSize = true;
			lbl_lecturer_fullName.Font = new Font("Source Sans 3", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lbl_lecturer_fullName.Location = new Point(438, 54);
			lbl_lecturer_fullName.Name = "lbl_lecturer_fullName";
			lbl_lecturer_fullName.Size = new Size(104, 28);
			lbl_lecturer_fullName.TabIndex = 3;
			lbl_lecturer_fullName.Text = "Lecturer: ";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(199, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(168, 85);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 2;
			pictureBox1.TabStop = false;
			// 
			// picBox_unisel
			// 
			picBox_unisel.Image = (Image)resources.GetObject("picBox_unisel.Image");
			picBox_unisel.Location = new Point(30, 17);
			picBox_unisel.Name = "picBox_unisel";
			picBox_unisel.Size = new Size(139, 72);
			picBox_unisel.SizeMode = PictureBoxSizeMode.Zoom;
			picBox_unisel.TabIndex = 1;
			picBox_unisel.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Source Sans 3 Medium", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(438, 9);
			label1.Name = "label1";
			label1.Size = new Size(470, 45);
			label1.TabIndex = 0;
			label1.Text = "Lecturer Course Management";
			// 
			// contextMenuStrip1
			// 
			contextMenuStrip1.ImageScalingSize = new Size(20, 20);
			contextMenuStrip1.Name = "contextMenuStrip1";
			contextMenuStrip1.Size = new Size(61, 4);
			// 
			// tabControl
			// 
			tabControl.Controls.Add(home);
			tabControl.Controls.Add(view_data);
			tabControl.Controls.Add(update_data);
			tabControl.Controls.Add(choose_student);
			tabControl.Controls.Add(search_phone);
			tabControl.Controls.Add(create_course);
			tabControl.Controls.Add(drop_course);
			tabControl.Font = new Font("Source Sans 3 Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			tabControl.Location = new Point(0, 118);
			tabControl.Name = "tabControl";
			tabControl.SelectedIndex = 0;
			tabControl.Size = new Size(1232, 327);
			tabControl.TabIndex = 2;
			// 
			// home
			// 
			home.BackColor = Color.White;
			home.Font = new Font("Source Sans 3 Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			home.Location = new Point(4, 29);
			home.Name = "home";
			home.Padding = new Padding(3);
			home.Size = new Size(1224, 294);
			home.TabIndex = 0;
			home.Text = "Home";
			// 
			// view_data
			// 
			view_data.BackColor = Color.White;
			view_data.Controls.Add(tabControl2);
			view_data.Font = new Font("Source Sans 3 Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			view_data.Location = new Point(4, 29);
			view_data.Name = "view_data";
			view_data.Padding = new Padding(3);
			view_data.Size = new Size(1224, 294);
			view_data.TabIndex = 1;
			view_data.Text = "View Data";
			// 
			// tabControl2
			// 
			tabControl2.Location = new Point(0, 0);
			tabControl2.Name = "tabControl2";
			tabControl2.SelectedIndex = 0;
			tabControl2.Size = new Size(1228, 298);
			tabControl2.TabIndex = 0;
			// 
			// update_data
			// 
			update_data.BackColor = Color.White;
			update_data.Controls.Add(tabControl1);
			update_data.Font = new Font("Source Sans 3 Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			update_data.Location = new Point(4, 29);
			update_data.Name = "update_data";
			update_data.Padding = new Padding(3);
			update_data.Size = new Size(1224, 294);
			update_data.TabIndex = 2;
			update_data.Text = "Update Data";
			// 
			// tabControl1
			// 
			tabControl1.Location = new Point(0, 0);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(1224, 294);
			tabControl1.TabIndex = 0;
			// 
			// choose_student
			// 
			choose_student.BackColor = Color.White;
			choose_student.Controls.Add(btn_choose);
			choose_student.Controls.Add(lbl_subtitle);
			choose_student.Controls.Add(lbl_title);
			choose_student.Controls.Add(comBox_teach);
			choose_student.Location = new Point(4, 29);
			choose_student.Name = "choose_student";
			choose_student.Size = new Size(1224, 294);
			choose_student.TabIndex = 3;
			choose_student.Text = "Choose Student";
			// 
			// btn_choose
			// 
			btn_choose.BackColor = Color.Black;
			btn_choose.ForeColor = Color.White;
			btn_choose.Location = new Point(536, 176);
			btn_choose.Name = "btn_choose";
			btn_choose.Size = new Size(94, 29);
			btn_choose.TabIndex = 3;
			btn_choose.Text = "Choose";
			btn_choose.UseVisualStyleBackColor = false;
			btn_choose.Click += btn_Choose_Click;
			// 
			// lbl_subtitle
			// 
			lbl_subtitle.AutoSize = true;
			lbl_subtitle.Font = new Font("Source Sans 3", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
			lbl_subtitle.Location = new Point(500, 50);
			lbl_subtitle.Name = "lbl_subtitle";
			lbl_subtitle.Size = new Size(169, 40);
			lbl_subtitle.TabIndex = 2;
			lbl_subtitle.Text = "randomly choose student \r\nfrom the selected course";
			// 
			// lbl_title
			// 
			lbl_title.AutoSize = true;
			lbl_title.Font = new Font("Source Sans 3 Medium", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_title.Location = new Point(472, 13);
			lbl_title.Name = "lbl_title";
			lbl_title.Size = new Size(218, 37);
			lbl_title.TabIndex = 1;
			lbl_title.Text = "Choose Student";
			// 
			// comBox_teach
			// 
			comBox_teach.FormattingEnabled = true;
			comBox_teach.Location = new Point(380, 107);
			comBox_teach.Name = "comBox_teach";
			comBox_teach.Size = new Size(401, 28);
			comBox_teach.TabIndex = 0;
			// 
			// search_phone
			// 
			search_phone.BackColor = Color.White;
			search_phone.Controls.Add(panelphone);
			search_phone.Controls.Add(btn_search);
			search_phone.Controls.Add(txtbox_phone);
			search_phone.Controls.Add(label3);
			search_phone.Controls.Add(lbl_searchtitle);
			search_phone.Location = new Point(4, 29);
			search_phone.Name = "search_phone";
			search_phone.Size = new Size(1224, 294);
			search_phone.TabIndex = 4;
			search_phone.Text = "Search Phone";
			// 
			// panelphone
			// 
			panelphone.Location = new Point(495, 7);
			panelphone.Name = "panelphone";
			panelphone.Size = new Size(719, 280);
			panelphone.TabIndex = 4;
			// 
			// btn_search
			// 
			btn_search.BackColor = Color.Black;
			btn_search.ForeColor = Color.White;
			btn_search.Location = new Point(282, 175);
			btn_search.Name = "btn_search";
			btn_search.Size = new Size(94, 29);
			btn_search.TabIndex = 3;
			btn_search.Text = "Search";
			btn_search.UseVisualStyleBackColor = false;
			btn_search.Click += btnSearch_Click;
			// 
			// txtbox_phone
			// 
			txtbox_phone.Font = new Font("Source Sans 3", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtbox_phone.Location = new Point(72, 175);
			txtbox_phone.Name = "txtbox_phone";
			txtbox_phone.Size = new Size(204, 29);
			txtbox_phone.TabIndex = 2;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Source Sans 3", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
			label3.Location = new Point(88, 61);
			label3.Name = "label3";
			label3.Size = new Size(276, 40);
			label3.TabIndex = 1;
			label3.Text = "you can search by using full phone number \r\nor partial phone number.\r\n";
			label3.TextAlign = ContentAlignment.TopCenter;
			// 
			// lbl_searchtitle
			// 
			lbl_searchtitle.AutoSize = true;
			lbl_searchtitle.Font = new Font("Source Sans 3", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_searchtitle.Location = new Point(80, 25);
			lbl_searchtitle.Name = "lbl_searchtitle";
			lbl_searchtitle.Size = new Size(296, 37);
			lbl_searchtitle.TabIndex = 0;
			lbl_searchtitle.Text = "Search Phone Number";
			// 
			// create_course
			// 
			create_course.BackColor = Color.White;
			create_course.Controls.Add(btn_create);
			create_course.Controls.Add(panel1);
			create_course.Controls.Add(lbl_group);
			create_course.Controls.Add(lbl_course);
			create_course.Controls.Add(comBox_courseList);
			create_course.Controls.Add(lbl_title_createcourse);
			create_course.Location = new Point(4, 29);
			create_course.Name = "create_course";
			create_course.Size = new Size(1224, 294);
			create_course.TabIndex = 5;
			create_course.Text = "Create Course";
			// 
			// btn_create
			// 
			btn_create.BackColor = Color.LawnGreen;
			btn_create.Location = new Point(490, 225);
			btn_create.Name = "btn_create";
			btn_create.Size = new Size(185, 29);
			btn_create.TabIndex = 7;
			btn_create.Text = "Create Course";
			btn_create.UseVisualStyleBackColor = false;
			btn_create.Click += btn_create_Click;
			// 
			// panel1
			// 
			panel1.Controls.Add(radio_g6);
			panel1.Controls.Add(radio_g3);
			panel1.Controls.Add(radio_g5);
			panel1.Controls.Add(radio_g4);
			panel1.Controls.Add(radio_g2);
			panel1.Controls.Add(radio_g1);
			panel1.Location = new Point(345, 154);
			panel1.Name = "panel1";
			panel1.Size = new Size(504, 26);
			panel1.TabIndex = 4;
			// 
			// radio_g6
			// 
			radio_g6.AutoSize = true;
			radio_g6.Font = new Font("Source Sans 3", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			radio_g6.Location = new Point(419, 2);
			radio_g6.Name = "radio_g6";
			radio_g6.Size = new Size(77, 22);
			radio_g6.TabIndex = 7;
			radio_g6.TabStop = true;
			radio_g6.Text = "Group 6";
			radio_g6.UseVisualStyleBackColor = true;
			// 
			// radio_g3
			// 
			radio_g3.AutoSize = true;
			radio_g3.Font = new Font("Source Sans 3", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			radio_g3.Location = new Point(170, 2);
			radio_g3.Name = "radio_g3";
			radio_g3.Size = new Size(77, 22);
			radio_g3.TabIndex = 2;
			radio_g3.TabStop = true;
			radio_g3.Text = "Group 3";
			radio_g3.UseVisualStyleBackColor = true;
			// 
			// radio_g5
			// 
			radio_g5.AutoSize = true;
			radio_g5.Font = new Font("Source Sans 3", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			radio_g5.Location = new Point(336, 2);
			radio_g5.Name = "radio_g5";
			radio_g5.Size = new Size(77, 22);
			radio_g5.TabIndex = 6;
			radio_g5.TabStop = true;
			radio_g5.Text = "Group 5";
			radio_g5.UseVisualStyleBackColor = true;
			// 
			// radio_g4
			// 
			radio_g4.AutoSize = true;
			radio_g4.Font = new Font("Source Sans 3", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			radio_g4.Location = new Point(253, 2);
			radio_g4.Name = "radio_g4";
			radio_g4.Size = new Size(77, 22);
			radio_g4.TabIndex = 5;
			radio_g4.TabStop = true;
			radio_g4.Text = "Group 4";
			radio_g4.UseVisualStyleBackColor = true;
			// 
			// radio_g2
			// 
			radio_g2.AutoSize = true;
			radio_g2.Font = new Font("Source Sans 3", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			radio_g2.Location = new Point(87, 2);
			radio_g2.Name = "radio_g2";
			radio_g2.Size = new Size(77, 22);
			radio_g2.TabIndex = 1;
			radio_g2.TabStop = true;
			radio_g2.Text = "Group 2";
			radio_g2.UseVisualStyleBackColor = true;
			// 
			// radio_g1
			// 
			radio_g1.AutoSize = true;
			radio_g1.Font = new Font("Source Sans 3", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			radio_g1.Location = new Point(4, 2);
			radio_g1.Name = "radio_g1";
			radio_g1.Size = new Size(77, 22);
			radio_g1.TabIndex = 0;
			radio_g1.TabStop = true;
			radio_g1.Text = "Group 1";
			radio_g1.UseVisualStyleBackColor = true;
			// 
			// lbl_group
			// 
			lbl_group.AutoSize = true;
			lbl_group.Font = new Font("Source Sans 3", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lbl_group.Location = new Point(284, 162);
			lbl_group.Name = "lbl_group";
			lbl_group.Size = new Size(50, 18);
			lbl_group.TabIndex = 3;
			lbl_group.Text = "Group:";
			// 
			// lbl_course
			// 
			lbl_course.AutoSize = true;
			lbl_course.Font = new Font("Source Sans 3", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lbl_course.Location = new Point(284, 120);
			lbl_course.Name = "lbl_course";
			lbl_course.Size = new Size(55, 18);
			lbl_course.TabIndex = 2;
			lbl_course.Text = "Course:";
			// 
			// comBox_courseList
			// 
			comBox_courseList.Font = new Font("Source Sans 3", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			comBox_courseList.FormattingEnabled = true;
			comBox_courseList.Location = new Point(345, 112);
			comBox_courseList.Name = "comBox_courseList";
			comBox_courseList.Size = new Size(504, 26);
			comBox_courseList.TabIndex = 1;
			comBox_courseList.SelectedIndexChanged += comBox_courseList_SelectedIndexChanged;
			// 
			// lbl_title_createcourse
			// 
			lbl_title_createcourse.AutoSize = true;
			lbl_title_createcourse.Font = new Font("Source Sans 3", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_title_createcourse.Location = new Point(465, 31);
			lbl_title_createcourse.Name = "lbl_title_createcourse";
			lbl_title_createcourse.Size = new Size(231, 45);
			lbl_title_createcourse.TabIndex = 0;
			lbl_title_createcourse.Text = "Create Course";
			// 
			// drop_course
			// 
			drop_course.BackColor = Color.White;
			drop_course.Controls.Add(btn_delete_all);
			drop_course.Controls.Add(btn_delete_course);
			drop_course.Controls.Add(comBox_delete);
			drop_course.Controls.Add(lbl_delete_course);
			drop_course.Controls.Add(label2);
			drop_course.Location = new Point(4, 29);
			drop_course.Name = "drop_course";
			drop_course.Size = new Size(1224, 294);
			drop_course.TabIndex = 6;
			drop_course.Text = "Drop Course";
			// 
			// btn_delete_all
			// 
			btn_delete_all.BackColor = Color.Red;
			btn_delete_all.ForeColor = Color.White;
			btn_delete_all.Location = new Point(763, 205);
			btn_delete_all.Name = "btn_delete_all";
			btn_delete_all.Size = new Size(232, 29);
			btn_delete_all.TabIndex = 6;
			btn_delete_all.Text = "Mass Delete Course";
			btn_delete_all.UseVisualStyleBackColor = false;
			btn_delete_all.Click += btn_delete_all_Click;
			// 
			// btn_delete_course
			// 
			btn_delete_course.BackColor = Color.Red;
			btn_delete_course.ForeColor = Color.White;
			btn_delete_course.Location = new Point(806, 92);
			btn_delete_course.Name = "btn_delete_course";
			btn_delete_course.Size = new Size(146, 29);
			btn_delete_course.TabIndex = 5;
			btn_delete_course.Text = "Delete Course";
			btn_delete_course.UseVisualStyleBackColor = false;
			btn_delete_course.Click += btn_delete_course_Click;
			// 
			// comBox_delete
			// 
			comBox_delete.Font = new Font("Source Sans 3", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			comBox_delete.FormattingEnabled = true;
			comBox_delete.Location = new Point(290, 93);
			comBox_delete.Name = "comBox_delete";
			comBox_delete.Size = new Size(504, 26);
			comBox_delete.TabIndex = 4;
			// 
			// lbl_delete_course
			// 
			lbl_delete_course.AutoSize = true;
			lbl_delete_course.Font = new Font("Source Sans 3", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lbl_delete_course.Location = new Point(229, 101);
			lbl_delete_course.Name = "lbl_delete_course";
			lbl_delete_course.Size = new Size(55, 18);
			lbl_delete_course.TabIndex = 3;
			lbl_delete_course.Text = "Course:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Source Sans 3", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(479, 19);
			label2.Name = "label2";
			label2.Size = new Size(230, 45);
			label2.TabIndex = 1;
			label2.Text = "Delete Course";
			// 
			// LecturerDashboard
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(1232, 495);
			Controls.Add(tabControl);
			Controls.Add(panel_title);
			Name = "LecturerDashboard";
			Text = "eTeaching";
			Load += LecturerDashboard_Load;
			panel_title.ResumeLayout(false);
			panel_title.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)picBox_unisel).EndInit();
			tabControl.ResumeLayout(false);
			view_data.ResumeLayout(false);
			update_data.ResumeLayout(false);
			choose_student.ResumeLayout(false);
			choose_student.PerformLayout();
			search_phone.ResumeLayout(false);
			search_phone.PerformLayout();
			create_course.ResumeLayout(false);
			create_course.PerformLayout();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			drop_course.ResumeLayout(false);
			drop_course.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel_title;
		private Label label1;
		private PictureBox picBox_unisel;
		private PictureBox pictureBox1;
		private Label lbl_lecturer_fullName;
		private ContextMenuStrip contextMenuStrip1;
		private TabControl tabControl;
		private TabPage home;
		private TabPage view_data;
		private TabPage update_data;
		private TabPage choose_student;
		private TabPage search_phone;
		private TabPage create_course;
		private TabPage drop_course;
		private Label lbl_title_createcourse;
		private ComboBox comBox_courseList;
		private Label lbl_course;
		private Label lbl_group;
		private Panel panel1;
		private RadioButton radio_g3;
		private RadioButton radio_g2;
		private RadioButton radio_g1;
		private RadioButton radio_g6;
		private RadioButton radio_g5;
		private RadioButton radio_g4;
		private Button btn_create;
		private Label label2;
		private Label lbl_delete_course;
		private Button btn_delete_course;
		private ComboBox comBox_delete;
		private Button btn_delete_all;
		private Button btn_logout;
		private TabControl tabControl1;
		private TabControl tabControl2;
		private Label label3;
		private Label lbl_searchtitle;
		private Button btn_search;
		private TextBox txtbox_phone;
		private Panel panelphone;
		private Button btn_choose;
		private Label lbl_subtitle;
		private Label lbl_title;
		private ComboBox comBox_teach;
	}
}