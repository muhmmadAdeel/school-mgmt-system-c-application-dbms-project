using System.Data.SqlClient;

namespace School_system
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
            loginBtn.Click += LoginBtn_Click;
            signUpTextLink.Click += SignUpTextLink_Click;
        }

        private void SignUpTextLink_Click(object? sender, EventArgs e)
        {
            this.Hide();
            signUp signUp  = new signUp();
            signUp.Show();
        }

        private void LoginBtn_Click(object? sender, EventArgs e)
        {
            db db   = new db();
            string connectionString = db.get_db();
            string username = UserNameTextBox.Text;
            string password = PassTextBox.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE username = @Username AND Password = @Password";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        int userCount = (int)cmd.ExecuteScalar();
                        if (userCount > 0)
                        {
                            // Login successful, open the main form
                            MainForm mainForm = new MainForm();
                            mainForm.Show();
                            this.Hide();  // Hide login form
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to database: " + ex.Message);
                }
            }
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
