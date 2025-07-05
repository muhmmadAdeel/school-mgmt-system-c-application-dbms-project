namespace School_system
{
    partial class student
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
            panel1 = new Panel();
            label1 = new Label();
            Namelabel = new Label();
            NametextBox = new TextBox();
            DOBlabel = new Label();
            Genderlabel = new Label();
            Phonelabel = new Label();
            EmailLabel = new Label();
            GendertextBox = new TextBox();
            PhonetextBox = new TextBox();
            EmailtextBox = new TextBox();
            DOBtime = new DateTimePicker();
            Newbtn = new Button();
            updateBtn = new Button();
            deleteBtn = new Button();
            Displaybtn = new Button();
            dataGridView = new DataGridView();
            studentIDtextbox = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(968, 78);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.Blue;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(334, 9);
            label1.Name = "label1";
            label1.Size = new Size(285, 67);
            label1.TabIndex = 0;
            label1.Text = "Student";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // Namelabel
            // 
            Namelabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Namelabel.Location = new Point(36, 160);
            Namelabel.Name = "Namelabel";
            Namelabel.Size = new Size(162, 31);
            Namelabel.TabIndex = 3;
            Namelabel.Text = "Student Name";
            Namelabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NametextBox
            // 
            NametextBox.Location = new Point(238, 160);
            NametextBox.Name = "NametextBox";
            NametextBox.Size = new Size(289, 31);
            NametextBox.TabIndex = 4;
            // 
            // DOBlabel
            // 
            DOBlabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DOBlabel.Location = new Point(36, 218);
            DOBlabel.Name = "DOBlabel";
            DOBlabel.Size = new Size(144, 31);
            DOBlabel.TabIndex = 5;
            DOBlabel.Text = "Student DOB";
            DOBlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Genderlabel
            // 
            Genderlabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Genderlabel.Location = new Point(36, 271);
            Genderlabel.Name = "Genderlabel";
            Genderlabel.Size = new Size(162, 31);
            Genderlabel.TabIndex = 6;
            Genderlabel.Text = "Gender";
            Genderlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Phonelabel
            // 
            Phonelabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Phonelabel.Location = new Point(36, 323);
            Phonelabel.Name = "Phonelabel";
            Phonelabel.Size = new Size(162, 31);
            Phonelabel.TabIndex = 7;
            Phonelabel.Text = "Phone";
            Phonelabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EmailLabel
            // 
            EmailLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmailLabel.Location = new Point(36, 372);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(162, 31);
            EmailLabel.TabIndex = 8;
            EmailLabel.Text = "Email";
            EmailLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GendertextBox
            // 
            GendertextBox.Location = new Point(238, 271);
            GendertextBox.Name = "GendertextBox";
            GendertextBox.Size = new Size(289, 31);
            GendertextBox.TabIndex = 9;
            // 
            // PhonetextBox
            // 
            PhonetextBox.Location = new Point(238, 324);
            PhonetextBox.Name = "PhonetextBox";
            PhonetextBox.Size = new Size(289, 31);
            PhonetextBox.TabIndex = 10;
            // 
            // EmailtextBox
            // 
            EmailtextBox.Location = new Point(238, 372);
            EmailtextBox.Name = "EmailtextBox";
            EmailtextBox.Size = new Size(289, 31);
            EmailtextBox.TabIndex = 11;
            // 
            // DOBtime
            // 
            DOBtime.Location = new Point(238, 218);
            DOBtime.Name = "DOBtime";
            DOBtime.Size = new Size(300, 31);
            DOBtime.TabIndex = 12;
            // 
            // Newbtn
            // 
            Newbtn.BackColor = Color.Gold;
            Newbtn.Font = new Font("Segoe UI", 10F);
            Newbtn.Location = new Point(600, 200);
            Newbtn.Name = "Newbtn";
            Newbtn.Size = new Size(134, 49);
            Newbtn.TabIndex = 13;
            Newbtn.Text = "New";
            Newbtn.UseVisualStyleBackColor = false;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.Gold;
            updateBtn.Font = new Font("Segoe UI", 10F);
            updateBtn.Location = new Point(773, 200);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(134, 49);
            updateBtn.TabIndex = 14;
            updateBtn.Text = "update";
            updateBtn.UseVisualStyleBackColor = false;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.Gold;
            deleteBtn.Font = new Font("Segoe UI", 10F);
            deleteBtn.Location = new Point(600, 287);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(134, 49);
            deleteBtn.TabIndex = 15;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            // 
            // Displaybtn
            // 
            Displaybtn.BackColor = Color.Gold;
            Displaybtn.Font = new Font("Segoe UI", 10F);
            Displaybtn.Location = new Point(773, 287);
            Displaybtn.Name = "Displaybtn";
            Displaybtn.Size = new Size(134, 49);
            Displaybtn.TabIndex = 17;
            Displaybtn.Text = "Display";
            Displaybtn.UseVisualStyleBackColor = false;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(0, 444);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.Size = new Size(968, 242);
            dataGridView.TabIndex = 18;
            // 
            // studentIDtextbox
            // 
            studentIDtextbox.Location = new Point(238, 112);
            studentIDtextbox.Name = "studentIDtextbox";
            studentIDtextbox.Size = new Size(289, 31);
            studentIDtextbox.TabIndex = 20;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 112);
            label2.Name = "label2";
            label2.Size = new Size(162, 31);
            label2.TabIndex = 19;
            label2.Text = "Student ID";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // student
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 686);
            Controls.Add(studentIDtextbox);
            Controls.Add(label2);
            Controls.Add(dataGridView);
            Controls.Add(Displaybtn);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(Newbtn);
            Controls.Add(DOBtime);
            Controls.Add(EmailtextBox);
            Controls.Add(PhonetextBox);
            Controls.Add(GendertextBox);
            Controls.Add(EmailLabel);
            Controls.Add(Phonelabel);
            Controls.Add(Genderlabel);
            Controls.Add(DOBlabel);
            Controls.Add(NametextBox);
            Controls.Add(Namelabel);
            Controls.Add(panel1);
            Name = "student";
            Text = "student";
            Load += student_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label Namelabel;
        private TextBox NametextBox;
        private Label DOBlabel;
        private Label Genderlabel;
        private Label Phonelabel;
        private Label EmailLabel;
        private TextBox GendertextBox;
        private TextBox PhonetextBox;
        private TextBox EmailtextBox;
        private DateTimePicker DOBtime;
        private Button Newbtn;
        private Button updateBtn;
        private Button deleteBtn;
        private Button Displaybtn;
        private DataGridView dataGridView;
        private TextBox studentIDtextbox;
        private Label label2;
    }
}