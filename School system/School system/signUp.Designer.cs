namespace School_system
{
    partial class signUp
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
            label = new Label();
            SignUpBtn = new Button();
            PassTextBox = new TextBox();
            passLabel = new Label();
            UserNameTextBox = new TextBox();
            userLabel = new Label();
            NametextBox = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(label);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(746, 92);
            panel1.TabIndex = 7;
            // 
            // label
            // 
            label.Dock = DockStyle.Fill;
            label.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.ForeColor = Color.White;
            label.Location = new Point(0, 0);
            label.Name = "label";
            label.Size = new Size(746, 92);
            label.TabIndex = 0;
            label.Text = "Admin SignUp";
            label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SignUpBtn
            // 
            SignUpBtn.Location = new Point(234, 381);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new Size(317, 44);
            SignUpBtn.TabIndex = 12;
            SignUpBtn.Text = "Sign Up";
            SignUpBtn.UseVisualStyleBackColor = true;
            // 
            // PassTextBox
            // 
            PassTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PassTextBox.Location = new Point(234, 317);
            PassTextBox.Name = "PassTextBox";
            PassTextBox.Size = new Size(317, 34);
            PassTextBox.TabIndex = 11;
            PassTextBox.UseSystemPasswordChar = true;
            // 
            // passLabel
            // 
            passLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passLabel.Location = new Point(94, 317);
            passLabel.Name = "passLabel";
            passLabel.Size = new Size(124, 38);
            passLabel.TabIndex = 10;
            passLabel.Text = "Password :";
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserNameTextBox.Location = new Point(234, 245);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(317, 34);
            UserNameTextBox.TabIndex = 9;
            // 
            // userLabel
            // 
            userLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userLabel.Location = new Point(94, 248);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(124, 38);
            userLabel.TabIndex = 8;
            userLabel.Text = "Username :";
            // 
            // NametextBox
            // 
            NametextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NametextBox.Location = new Point(234, 181);
            NametextBox.Name = "NametextBox";
            NametextBox.Size = new Size(317, 34);
            NametextBox.TabIndex = 13;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(94, 177);
            label1.Name = "label1";
            label1.Size = new Size(124, 38);
            label1.TabIndex = 14;
            label1.Text = "Name :";
            // 
            // signUp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 576);
            Controls.Add(label1);
            Controls.Add(NametextBox);
            Controls.Add(panel1);
            Controls.Add(SignUpBtn);
            Controls.Add(PassTextBox);
            Controls.Add(passLabel);
            Controls.Add(UserNameTextBox);
            Controls.Add(userLabel);
            Name = "signUp";
            Text = "signUp";
            Load += signUp_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label;
        private Button SignUpBtn;
        private TextBox PassTextBox;
        private Label passLabel;
        private TextBox UserNameTextBox;
        private Label userLabel;
        private TextBox NametextBox;
        private Label label1;
    }
}