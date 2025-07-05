using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace School_system
{
    public partial class signUp : Form
    {
        public signUp()
        {
            InitializeComponent();
            SignUpBtn.Click += SignUpBtn_Click;
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            string name = NametextBox.Text.Trim();
            string username = UserNameTextBox.Text.Trim();
            string password = PassTextBox.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Replace with your actual connection string
            db db = new db();
            string connectionString = db.get_db();


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Users (Name, username, Password) VALUES (@Name, @Username, @Password)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sign up successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MainForm mainForm   = new MainForm();
                            mainForm.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Sign up failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearFields()
        {
            NametextBox.Text = "";
            UserNameTextBox.Text = "";
            PassTextBox.Text = "";
        }

        private void signUp_Load(object sender, EventArgs e)
        {

        }
    }
}
