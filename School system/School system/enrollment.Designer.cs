namespace School_system
{
    partial class enrollment
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
            DataGridView = new DataGridView();
            Displaybtn = new Button();
            deleteBtn = new Button();
            updateBtn = new Button();
            Newbtn = new Button();
            StudentIDtextBox = new TextBox();
            studentNamelabel = new Label();
            EIDtextBox = new TextBox();
            EIDLabel = new Label();
            label1 = new Label();
            CourseIDtextBox = new TextBox();
            SectionLabelN = new Label();
            panel1 = new Panel();
            EnrollDateLabel = new Label();
            GradetextBox = new TextBox();
            StatustextBox = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // DataGridView
            // 
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Location = new Point(0, 431);
            DataGridView.Name = "DataGridView";
            DataGridView.RowHeadersWidth = 62;
            DataGridView.Size = new Size(968, 242);
            DataGridView.TabIndex = 64;
            // 
            // Displaybtn
            // 
            Displaybtn.BackColor = Color.Gold;
            Displaybtn.Font = new Font("Segoe UI", 10F);
            Displaybtn.Location = new Point(773, 274);
            Displaybtn.Name = "Displaybtn";
            Displaybtn.Size = new Size(134, 49);
            Displaybtn.TabIndex = 63;
            Displaybtn.Text = "Display";
            Displaybtn.UseVisualStyleBackColor = false;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.Gold;
            deleteBtn.Font = new Font("Segoe UI", 10F);
            deleteBtn.Location = new Point(600, 274);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(134, 49);
            deleteBtn.TabIndex = 61;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.Gold;
            updateBtn.Font = new Font("Segoe UI", 10F);
            updateBtn.Location = new Point(773, 187);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(134, 49);
            updateBtn.TabIndex = 60;
            updateBtn.Text = "update";
            updateBtn.UseVisualStyleBackColor = false;
            // 
            // Newbtn
            // 
            Newbtn.BackColor = Color.Gold;
            Newbtn.Font = new Font("Segoe UI", 10F);
            Newbtn.Location = new Point(600, 187);
            Newbtn.Name = "Newbtn";
            Newbtn.Size = new Size(134, 49);
            Newbtn.TabIndex = 59;
            Newbtn.Text = "New";
            Newbtn.UseVisualStyleBackColor = false;
            // 
            // StudentIDtextBox
            // 
            StudentIDtextBox.Location = new Point(216, 197);
            StudentIDtextBox.Name = "StudentIDtextBox";
            StudentIDtextBox.Size = new Size(289, 31);
            StudentIDtextBox.TabIndex = 58;
            // 
            // studentNamelabel
            // 
            studentNamelabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentNamelabel.Location = new Point(30, 197);
            studentNamelabel.Name = "studentNamelabel";
            studentNamelabel.Size = new Size(162, 31);
            studentNamelabel.TabIndex = 57;
            studentNamelabel.Text = "Student ID";
            studentNamelabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EIDtextBox
            // 
            EIDtextBox.Location = new Point(216, 134);
            EIDtextBox.Name = "EIDtextBox";
            EIDtextBox.Size = new Size(289, 31);
            EIDtextBox.TabIndex = 56;
            // 
            // EIDLabel
            // 
            EIDLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EIDLabel.Location = new Point(46, 134);
            EIDLabel.Name = "EIDLabel";
            EIDLabel.Size = new Size(125, 36);
            EIDLabel.TabIndex = 55;
            EIDLabel.Text = "EID";
            EIDLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.Blue;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(357, 9);
            label1.Name = "label1";
            label1.Size = new Size(285, 67);
            label1.TabIndex = 0;
            label1.Text = "Enrollment";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CourseIDtextBox
            // 
            CourseIDtextBox.Location = new Point(216, 261);
            CourseIDtextBox.Name = "CourseIDtextBox";
            CourseIDtextBox.Size = new Size(289, 31);
            CourseIDtextBox.TabIndex = 67;
            // 
            // SectionLabelN
            // 
            SectionLabelN.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SectionLabelN.Location = new Point(30, 261);
            SectionLabelN.Name = "SectionLabelN";
            SectionLabelN.Size = new Size(162, 31);
            SectionLabelN.TabIndex = 66;
            SectionLabelN.Text = "course ID";
            SectionLabelN.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1049, 78);
            panel1.TabIndex = 54;
            // 
            // EnrollDateLabel
            // 
            EnrollDateLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EnrollDateLabel.Location = new Point(30, 331);
            EnrollDateLabel.Name = "EnrollDateLabel";
            EnrollDateLabel.Size = new Size(162, 31);
            EnrollDateLabel.TabIndex = 68;
            EnrollDateLabel.Text = "Grade ";
            EnrollDateLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GradetextBox
            // 
            GradetextBox.Location = new Point(216, 331);
            GradetextBox.Name = "GradetextBox";
            GradetextBox.Size = new Size(289, 31);
            GradetextBox.TabIndex = 69;
            // 
            // StatustextBox
            // 
            StatustextBox.Location = new Point(216, 381);
            StatustextBox.Name = "StatustextBox";
            StatustextBox.Size = new Size(289, 31);
            StatustextBox.TabIndex = 71;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 381);
            label2.Name = "label2";
            label2.Size = new Size(162, 31);
            label2.TabIndex = 70;
            label2.Text = "status";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // enrollment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 677);
            Controls.Add(StatustextBox);
            Controls.Add(label2);
            Controls.Add(GradetextBox);
            Controls.Add(EnrollDateLabel);
            Controls.Add(DataGridView);
            Controls.Add(Displaybtn);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(Newbtn);
            Controls.Add(StudentIDtextBox);
            Controls.Add(studentNamelabel);
            Controls.Add(EIDtextBox);
            Controls.Add(EIDLabel);
            Controls.Add(CourseIDtextBox);
            Controls.Add(SectionLabelN);
            Controls.Add(panel1);
            Name = "enrollment";
            Text = "enrollment";
            Load += enrollment_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView DataGridView;
        private Button Displaybtn;
        private Button deleteBtn;
        private Button updateBtn;
        private Button Newbtn;
        private TextBox StudentIDtextBox;
        private Label studentNamelabel;
        private TextBox EIDtextBox;
        private Label EIDLabel;
        private Label label1;
        private TextBox CourseIDtextBox;
        private Label SectionLabelN;
        private Panel panel1;
        private Label EnrollDateLabel;
        private TextBox GradetextBox;
        private TextBox StatustextBox;
        private Label label2;
    }
}