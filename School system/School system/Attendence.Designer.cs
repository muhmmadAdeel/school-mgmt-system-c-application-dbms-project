namespace School_system
{
    partial class Attendence
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
            label1 = new Label();
            DataGridView = new DataGridView();
            Displaybtn = new Button();
            deleteBtn = new Button();
            updateBtn = new Button();
            Newbtn = new Button();
            AIDDtextBox = new TextBox();
            AIDLabel = new Label();
            DescriptiontextBox = new TextBox();
            StatusLabel = new Label();
            panel1 = new Panel();
            SIDTextBox = new TextBox();
            SIDDateLabel = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            label1.Text = "Attendence";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DataGridView
            // 
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Location = new Point(0, 436);
            DataGridView.Name = "DataGridView";
            DataGridView.RowHeadersWidth = 62;
            DataGridView.Size = new Size(968, 242);
            DataGridView.TabIndex = 80;
            // 
            // Displaybtn
            // 
            Displaybtn.BackColor = Color.Gold;
            Displaybtn.Font = new Font("Segoe UI", 10F);
            Displaybtn.Location = new Point(763, 239);
            Displaybtn.Name = "Displaybtn";
            Displaybtn.Size = new Size(134, 49);
            Displaybtn.TabIndex = 79;
            Displaybtn.Text = "Display";
            Displaybtn.UseVisualStyleBackColor = false;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.Gold;
            deleteBtn.Font = new Font("Segoe UI", 10F);
            deleteBtn.Location = new Point(600, 239);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(134, 49);
            deleteBtn.TabIndex = 77;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.Gold;
            updateBtn.Font = new Font("Segoe UI", 10F);
            updateBtn.Location = new Point(763, 156);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(134, 49);
            updateBtn.TabIndex = 76;
            updateBtn.Text = "update";
            updateBtn.UseVisualStyleBackColor = false;
            // 
            // Newbtn
            // 
            Newbtn.BackColor = Color.Gold;
            Newbtn.Font = new Font("Segoe UI", 10F);
            Newbtn.Location = new Point(600, 156);
            Newbtn.Name = "Newbtn";
            Newbtn.Size = new Size(134, 49);
            Newbtn.TabIndex = 75;
            Newbtn.Text = "New";
            Newbtn.UseVisualStyleBackColor = false;
            // 
            // AIDDtextBox
            // 
            AIDDtextBox.Location = new Point(216, 139);
            AIDDtextBox.Name = "AIDDtextBox";
            AIDDtextBox.Size = new Size(289, 31);
            AIDDtextBox.TabIndex = 72;
            // 
            // AIDLabel
            // 
            AIDLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AIDLabel.Location = new Point(46, 139);
            AIDLabel.Name = "AIDLabel";
            AIDLabel.Size = new Size(125, 36);
            AIDLabel.TabIndex = 71;
            AIDLabel.Text = "AID";
            AIDLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DescriptiontextBox
            // 
            DescriptiontextBox.Location = new Point(216, 271);
            DescriptiontextBox.Name = "DescriptiontextBox";
            DescriptiontextBox.Size = new Size(289, 31);
            DescriptiontextBox.TabIndex = 83;
            // 
            // StatusLabel
            // 
            StatusLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StatusLabel.Location = new Point(30, 271);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(162, 31);
            StatusLabel.TabIndex = 82;
            StatusLabel.Text = "description";
            StatusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1054, 78);
            panel1.TabIndex = 70;
            // 
            // SIDTextBox
            // 
            SIDTextBox.Location = new Point(216, 201);
            SIDTextBox.Name = "SIDTextBox";
            SIDTextBox.Size = new Size(289, 31);
            SIDTextBox.TabIndex = 85;
            // 
            // SIDDateLabel
            // 
            SIDDateLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SIDDateLabel.Location = new Point(30, 201);
            SIDDateLabel.Name = "SIDDateLabel";
            SIDDateLabel.Size = new Size(162, 31);
            SIDDateLabel.TabIndex = 84;
            SIDDateLabel.Text = "SID";
            SIDDateLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 322);
            label2.Name = "label2";
            label2.Size = new Size(162, 31);
            label2.TabIndex = 86;
            label2.Text = "date";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(216, 334);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 88;
            // 
            // Attendence
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 682);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(SIDDateLabel);
            Controls.Add(SIDTextBox);
            Controls.Add(DataGridView);
            Controls.Add(Displaybtn);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(Newbtn);
            Controls.Add(AIDDtextBox);
            Controls.Add(AIDLabel);
            Controls.Add(DescriptiontextBox);
            Controls.Add(StatusLabel);
            Controls.Add(panel1);
            Name = "Attendence";
            Text = "Attendence";
            Load += Attendence_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView DataGridView;
        private Button Displaybtn;
        private Button deleteBtn;
        private Button updateBtn;
        private Button Newbtn;
        private TextBox AIDDtextBox;
        private Label AIDLabel;
        private TextBox DescriptiontextBox;
        private Label StatusLabel;
        private Panel panel1;
        private TextBox SIDTextBox;
        private Label SIDDateLabel;
        private Label label2;
        private DateTimePicker dateTimePicker1;
    }
}