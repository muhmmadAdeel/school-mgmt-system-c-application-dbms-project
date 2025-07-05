namespace School_system
{
    partial class Login_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label = new Label();
            userLabel = new Label();
            UserNameTextBox = new TextBox();
            passLabel = new Label();
            PassTextBox = new TextBox();
            loginBtn = new Button();
            signUpTextLink = new LinkLabel();
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
            panel1.Size = new Size(677, 92);
            panel1.TabIndex = 0;
            // 
            // label
            // 
            label.Dock = DockStyle.Fill;
            label.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.ForeColor = Color.White;
            label.Location = new Point(0, 0);
            label.Name = "label";
            label.Size = new Size(677, 92);
            label.TabIndex = 0;
            label.Text = "Admin Login";
            label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // userLabel
            // 
            userLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userLabel.Location = new Point(44, 179);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(124, 38);
            userLabel.TabIndex = 1;
            userLabel.Text = "Username :";
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserNameTextBox.Location = new Point(184, 176);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(317, 34);
            UserNameTextBox.TabIndex = 3;
            // 
            // passLabel
            // 
            passLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passLabel.Location = new Point(44, 248);
            passLabel.Name = "passLabel";
            passLabel.Size = new Size(124, 38);
            passLabel.TabIndex = 4;
            passLabel.Text = "Password :";
            // 
            // PassTextBox
            // 
            PassTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PassTextBox.Location = new Point(184, 248);
            PassTextBox.Name = "PassTextBox";
            PassTextBox.Size = new Size(317, 34);
            PassTextBox.TabIndex = 5;
            PassTextBox.UseSystemPasswordChar = true;
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(184, 312);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(317, 44);
            loginBtn.TabIndex = 6;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            // 
            // signUpTextLink
            // 
            signUpTextLink.AutoSize = true;
            signUpTextLink.Location = new Point(385, 367);
            signUpTextLink.Name = "signUpTextLink";
            signUpTextLink.Size = new Size(75, 25);
            signUpTextLink.TabIndex = 7;
            signUpTextLink.TabStop = true;
            signUpTextLink.Text = "Sign Up";
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 450);
            Controls.Add(signUpTextLink);
            Controls.Add(loginBtn);
            Controls.Add(PassTextBox);
            Controls.Add(passLabel);
            Controls.Add(UserNameTextBox);
            Controls.Add(userLabel);
            Controls.Add(panel1);
            Name = "Login_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Form_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label;
        private Label userLabel;
        private Label label2;
        private TextBox UserNameTextBox;
        private Label passLabel;
        private TextBox PassTextBox;
        private Button loginBtn;
        private LinkLabel signUpTextLink;
    }
}
