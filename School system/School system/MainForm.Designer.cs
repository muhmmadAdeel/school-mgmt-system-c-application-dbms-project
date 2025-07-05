namespace School_system
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            label1 = new Label();
            MainPictureBox = new PictureBox();
            panel2 = new Panel();
            DashboardBtn = new Button();
            attendenceBtn = new Button();
            EnrollmentBtn = new Button();
            TeacherBtn = new Button();
            subjectbtn = new Button();
            studentBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainPictureBox).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1011, 86);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.BackColor = Color.Blue;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(258, 24);
            label1.Name = "label1";
            label1.Size = new Size(529, 62);
            label1.TabIndex = 0;
            label1.Text = "School management system";
            // 
            // MainPictureBox
            // 
            MainPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            MainPictureBox.BackgroundImageLayout = ImageLayout.None;
            MainPictureBox.ErrorImage = (Image)resources.GetObject("MainPictureBox.ErrorImage");
            MainPictureBox.Image = (Image)resources.GetObject("MainPictureBox.Image");
            MainPictureBox.Location = new Point(313, 89);
            MainPictureBox.Name = "MainPictureBox";
            MainPictureBox.Size = new Size(686, 568);
            MainPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            MainPictureBox.TabIndex = 1;
            MainPictureBox.TabStop = false;
            MainPictureBox.Click += MainPictureBox_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Controls.Add(DashboardBtn);
            panel2.Controls.Add(attendenceBtn);
            panel2.Controls.Add(EnrollmentBtn);
            panel2.Controls.Add(TeacherBtn);
            panel2.Controls.Add(subjectbtn);
            panel2.Controls.Add(studentBtn);
            panel2.Location = new Point(7, 92);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 565);
            panel2.TabIndex = 2;
            // 
            // DashboardBtn
            // 
            DashboardBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DashboardBtn.Location = new Point(35, 416);
            DashboardBtn.Name = "DashboardBtn";
            DashboardBtn.Size = new Size(219, 54);
            DashboardBtn.TabIndex = 6;
            DashboardBtn.Text = "Dashboard";
            DashboardBtn.UseVisualStyleBackColor = true;
            // 
            // attendenceBtn
            // 
            attendenceBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            attendenceBtn.Location = new Point(35, 334);
            attendenceBtn.Name = "attendenceBtn";
            attendenceBtn.Size = new Size(219, 54);
            attendenceBtn.TabIndex = 5;
            attendenceBtn.Text = "Attendence";
            attendenceBtn.UseVisualStyleBackColor = true;
            // 
            // EnrollmentBtn
            // 
            EnrollmentBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EnrollmentBtn.Location = new Point(35, 251);
            EnrollmentBtn.Name = "EnrollmentBtn";
            EnrollmentBtn.Size = new Size(219, 54);
            EnrollmentBtn.TabIndex = 4;
            EnrollmentBtn.Text = "Enrollment";
            EnrollmentBtn.UseVisualStyleBackColor = true;
            // 
            // TeacherBtn
            // 
            TeacherBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TeacherBtn.Location = new Point(35, 161);
            TeacherBtn.Name = "TeacherBtn";
            TeacherBtn.Size = new Size(219, 54);
            TeacherBtn.TabIndex = 2;
            TeacherBtn.Text = "Teacher";
            TeacherBtn.UseVisualStyleBackColor = true;
            // 
            // subjectbtn
            // 
            subjectbtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subjectbtn.Location = new Point(35, 86);
            subjectbtn.Name = "subjectbtn";
            subjectbtn.Size = new Size(219, 54);
            subjectbtn.TabIndex = 1;
            subjectbtn.Text = "Subject";
            subjectbtn.UseVisualStyleBackColor = true;
            // 
            // studentBtn
            // 
            studentBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentBtn.Location = new Point(35, 12);
            studentBtn.Name = "studentBtn";
            studentBtn.Size = new Size(219, 54);
            studentBtn.TabIndex = 0;
            studentBtn.Text = "Student";
            studentBtn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 657);
            Controls.Add(panel2);
            Controls.Add(MainPictureBox);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "Main";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MainPictureBox).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox MainPictureBox;
        private Panel panel2;
        private Button DashboardBtn;
        private Button attendenceBtn;
        private Button EnrollmentBtn;
        private Button TeacherBtn;
        private Button subjectbtn;
        private Button studentBtn;
    }
}