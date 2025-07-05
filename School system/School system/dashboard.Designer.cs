namespace School_system
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            totalStudentLabel = new Label();
            panel4 = new Panel();
            TotalSubjectsLabel = new Label();
            panel5 = new Panel();
            TotalTeacherLabel = new Label();
            panel6 = new Panel();
            TotalEnrollmentLabel = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1078, 102);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 24);
            label1.Name = "label1";
            label1.Size = new Size(341, 61);
            label1.TabIndex = 0;
            label1.Text = "Admin Dashboard";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGreen;
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 102);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 574);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(41, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 197);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 128, 255);
            panel3.Controls.Add(totalStudentLabel);
            panel3.Location = new Point(354, 128);
            panel3.Name = "panel3";
            panel3.Size = new Size(271, 229);
            panel3.TabIndex = 2;
            // 
            // totalStudentLabel
            // 
            totalStudentLabel.AutoSize = true;
            totalStudentLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalStudentLabel.ForeColor = Color.White;
            totalStudentLabel.Location = new Point(12, 32);
            totalStudentLabel.Name = "totalStudentLabel";
            totalStudentLabel.Size = new Size(148, 32);
            totalStudentLabel.TabIndex = 0;
            totalStudentLabel.Text = "Students : 0";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 128, 255);
            panel4.Controls.Add(TotalSubjectsLabel);
            panel4.Location = new Point(720, 128);
            panel4.Name = "panel4";
            panel4.Size = new Size(271, 229);
            panel4.TabIndex = 3;
            // 
            // TotalSubjectsLabel
            // 
            TotalSubjectsLabel.AutoSize = true;
            TotalSubjectsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalSubjectsLabel.ForeColor = Color.White;
            TotalSubjectsLabel.Location = new Point(19, 32);
            TotalSubjectsLabel.Name = "TotalSubjectsLabel";
            TotalSubjectsLabel.Size = new Size(144, 32);
            TotalSubjectsLabel.TabIndex = 2;
            TotalSubjectsLabel.Text = "Subjects : 0";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 128, 255);
            panel5.Controls.Add(TotalTeacherLabel);
            panel5.Location = new Point(354, 415);
            panel5.Name = "panel5";
            panel5.Size = new Size(271, 229);
            panel5.TabIndex = 3;
            // 
            // TotalTeacherLabel
            // 
            TotalTeacherLabel.AutoSize = true;
            TotalTeacherLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalTeacherLabel.ForeColor = Color.White;
            TotalTeacherLabel.Location = new Point(12, 40);
            TotalTeacherLabel.Name = "TotalTeacherLabel";
            TotalTeacherLabel.Size = new Size(147, 32);
            TotalTeacherLabel.TabIndex = 3;
            TotalTeacherLabel.Text = "Teachers : 0";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(255, 128, 255);
            panel6.Controls.Add(TotalEnrollmentLabel);
            panel6.Location = new Point(720, 415);
            panel6.Name = "panel6";
            panel6.Size = new Size(271, 229);
            panel6.TabIndex = 3;
            // 
            // TotalEnrollmentLabel
            // 
            TotalEnrollmentLabel.AutoSize = true;
            TotalEnrollmentLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalEnrollmentLabel.ForeColor = Color.White;
            TotalEnrollmentLabel.Location = new Point(19, 40);
            TotalEnrollmentLabel.Name = "TotalEnrollmentLabel";
            TotalEnrollmentLabel.Size = new Size(186, 32);
            TotalEnrollmentLabel.TabIndex = 3;
            TotalEnrollmentLabel.Text = "Enrollments : 0";
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 676);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "dashboard";
            Text = "dashboard";
            Load += dashboard_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label Snolabel;
        private Label totalStudentLabel;
        private Panel panel4;
        private Label SubjectNolabel;
        private Label TotalSubjectsLabel;
        private Panel panel5;
        private Panel panel6;
        private Label TotalTeacherLabel;
        private Label EnrollNolabel;
        private Label TotalEnrollmentLabel;
    }
}