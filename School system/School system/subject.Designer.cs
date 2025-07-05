namespace School_system
{
    partial class subject
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
            SubjectDataGridView = new DataGridView();
            Displaybtn = new Button();
            deleteBtn = new Button();
            updateBtn = new Button();
            Newbtn = new Button();
            studentIDtextbox = new TextBox();
            SubjectNamelabel = new Label();
            SubjectIDtextBox = new TextBox();
            SubjectLabel = new Label();
            label1 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)SubjectDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // SubjectDataGridView
            // 
            SubjectDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SubjectDataGridView.Location = new Point(0, 418);
            SubjectDataGridView.Name = "SubjectDataGridView";
            SubjectDataGridView.RowHeadersWidth = 62;
            SubjectDataGridView.Size = new Size(968, 242);
            SubjectDataGridView.TabIndex = 38;
            // 
            // Displaybtn
            // 
            Displaybtn.BackColor = Color.Gold;
            Displaybtn.Font = new Font("Segoe UI", 10F);
            Displaybtn.Location = new Point(773, 261);
            Displaybtn.Name = "Displaybtn";
            Displaybtn.Size = new Size(134, 49);
            Displaybtn.TabIndex = 37;
            Displaybtn.Text = "Display";
            Displaybtn.UseVisualStyleBackColor = false;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.Gold;
            deleteBtn.Font = new Font("Segoe UI", 10F);
            deleteBtn.Location = new Point(600, 261);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(134, 49);
            deleteBtn.TabIndex = 35;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.Gold;
            updateBtn.Font = new Font("Segoe UI", 10F);
            updateBtn.Location = new Point(773, 174);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(134, 49);
            updateBtn.TabIndex = 34;
            updateBtn.Text = "update";
            updateBtn.UseVisualStyleBackColor = false;
            // 
            // Newbtn
            // 
            Newbtn.BackColor = Color.Gold;
            Newbtn.Font = new Font("Segoe UI", 10F);
            Newbtn.Location = new Point(600, 174);
            Newbtn.Name = "Newbtn";
            Newbtn.Size = new Size(134, 49);
            Newbtn.TabIndex = 33;
            Newbtn.Text = "New";
            Newbtn.UseVisualStyleBackColor = false;
            // 
            // studentIDtextbox
            // 
            studentIDtextbox.Location = new Point(216, 279);
            studentIDtextbox.Name = "studentIDtextbox";
            studentIDtextbox.Size = new Size(289, 31);
            studentIDtextbox.TabIndex = 24;
            // 
            // SubjectNamelabel
            // 
            SubjectNamelabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubjectNamelabel.Location = new Point(26, 279);
            SubjectNamelabel.Name = "SubjectNamelabel";
            SubjectNamelabel.Size = new Size(162, 31);
            SubjectNamelabel.TabIndex = 23;
            SubjectNamelabel.Text = "student ID";
            SubjectNamelabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SubjectIDtextBox
            // 
            SubjectIDtextBox.Location = new Point(216, 207);
            SubjectIDtextBox.Name = "SubjectIDtextBox";
            SubjectIDtextBox.Size = new Size(289, 31);
            SubjectIDtextBox.TabIndex = 22;
            // 
            // SubjectLabel
            // 
            SubjectLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubjectLabel.Location = new Point(43, 202);
            SubjectLabel.Name = "SubjectLabel";
            SubjectLabel.Size = new Size(125, 36);
            SubjectLabel.TabIndex = 21;
            SubjectLabel.Text = "Subject ID";
            SubjectLabel.TextAlign = ContentAlignment.MiddleCenter;
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
            label1.Text = "Subject";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 78);
            panel1.TabIndex = 20;
            // 
            // subject
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 675);
            Controls.Add(SubjectDataGridView);
            Controls.Add(Displaybtn);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(Newbtn);
            Controls.Add(studentIDtextbox);
            Controls.Add(SubjectNamelabel);
            Controls.Add(SubjectIDtextBox);
            Controls.Add(SubjectLabel);
            Controls.Add(panel1);
            Name = "subject";
            Text = "subject";
            Load += subject_Load;
            ((System.ComponentModel.ISupportInitialize)SubjectDataGridView).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView SubjectDataGridView;
        private Button Displaybtn;
        private Button deleteBtn;
        private Button updateBtn;
        private Button Newbtn;
        private TextBox studentIDtextbox;
        private Label SubjectNamelabel;
        private TextBox SubjectIDtextBox;
        private Label SubjectLabel;
        private Label label1;
        private Panel panel1;
    }
}