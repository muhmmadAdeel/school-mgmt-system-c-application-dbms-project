using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_system
{
    public partial class teacher : Form
    {
        public teacher()
        {
            InitializeComponent();
            Newbtn.Click += Newbtn_Click;
            updateBtn.Click += UpdateBtn_Click;
            deleteBtn.Click += DeleteBtn_Click;
            Displaybtn.Click += Displaybtn_Click;

        }

        private void Displaybtn_Click(object? sender, EventArgs e)
        {
            db db = new db();
            string connectionString = db.get_db();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string selectQuery = @"
                SELECT 
                    teacher_id AS [Teacher ID],
                    teacher_name AS [Name],
                    gender AS [Gender],
                    phone AS [Phone],
                    email AS [Email]
                FROM 
                    teacher
                ORDER BY 
                    teacher_name";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);

                        // Bind data to DataGridView
                        TeacherdataGridView.DataSource = dataTable;

                        // Configure DataGridView appearance
                        TeacherdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        TeacherdataGridView.AllowUserToAddRows = false;
                        TeacherdataGridView.ReadOnly = true;
                        TeacherdataGridView.RowHeadersVisible = false;

                        // Enable row selection
                        TeacherdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                        // Add alternating row colors
                        TeacherdataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

                        // Format header style
                        TeacherdataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                        TeacherdataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
                        TeacherdataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error while loading teachers:\n" + ex.Message,
                                  "Error",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while loading teachers:\n" + ex.Message,
                                  "Error",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                }
            }
        }


        private void DeleteBtn_Click(object? sender, EventArgs e)
        {
            string t_id = TeacherIDtextBox.Text;

            // Validate input
            if (string.IsNullOrEmpty(t_id))
            {
                MessageBox.Show("Please enter a Teacher ID");
                return;
            }

            if (!int.TryParse(t_id, out int teacherId))
            {
                MessageBox.Show("Invalid Teacher ID format. Please enter a number.");
                return;
            }

            // Confirmation dialog
            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to delete teacher with ID: {teacherId}?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            db db = new db();
            string connectionString = db.get_db();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // First check if teacher exists
                    string checkQuery = "SELECT teacher_name FROM teacher WHERE teacher_id = @teacherId";
                    string teacherName = "";

                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@teacherId", teacherId);
                        var result = checkCmd.ExecuteScalar();

                        if (result == null)
                        {
                            MessageBox.Show("Teacher with this ID does not exist.");
                            return;
                        }
                        teacherName = result.ToString();
                    }

                    // Delete teacher
                    string deleteQuery = "DELETE FROM teacher WHERE teacher_id = @teacherId";

                    using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, connection))
                    {
                        deleteCmd.Parameters.AddWithValue("@teacherId", teacherId);

                        int rowsAffected = deleteCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Successfully deleted teacher: {teacherName} (ID: {teacherId})");
                            TeacherIDtextBox.Text = ""; // Clear the field
                        }
                        else
                        {
                            MessageBox.Show("No teacher was deleted.");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547) // Foreign key constraint violation
                    {
                        MessageBox.Show("Cannot delete this teacher because they are assigned to courses.\n" +
                                      "Please remove their course assignments first.");
                    }
                    else
                    {
                        MessageBox.Show("Database error: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void UpdateBtn_Click(object? sender, EventArgs e)
        {
           string t_id = TeacherIDtextBox.Text;
        }

        private void Newbtn_Click(object? sender, EventArgs e)
        {
            string t_name = TeacherNametextBox.Text;
            string t_gender = TeacherGendertextBox.Text;
            string t_phone = TeacherPhonetextBox.Text;
            string t_email = TeacherEmailtextBox.Text;

            // Validate inputs
            if (string.IsNullOrEmpty(t_name) || string.IsNullOrEmpty(t_email))
            {
                MessageBox.Show("Teacher name and email are required fields!");
                return;
            }

            // Validate gender (optional field)
            if (!string.IsNullOrEmpty(t_gender) && !(t_gender.ToUpper() == "M" || t_gender.ToUpper() == "F" || t_gender.ToUpper() == "O"))
            {
                MessageBox.Show("Please enter valid gender (M, F, or O)");
                return;
            }

            // Validate email format
            try
            {
                var email = new System.Net.Mail.MailAddress(t_email);
            }
            catch
            {
                MessageBox.Show("Please enter a valid email address");
                return;
            }

            db db = new db();
            string connectionString = db.get_db();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Check if email already exists
                    string checkEmailQuery = "SELECT COUNT(1) FROM teacher WHERE email = @email";
                    using (SqlCommand checkCmd = new SqlCommand(checkEmailQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@email", t_email);
                        int emailExists = (int)checkCmd.ExecuteScalar();

                        if (emailExists > 0)
                        {
                            MessageBox.Show("This email is already registered for another teacher");
                            return;
                        }
                    }

                    // Insert new teacher
                    string insertQuery = @"
                INSERT INTO teacher (teacher_name, gender, phone, email)
                VALUES (@name, @gender, @phone, @email)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@name", t_name);
                        command.Parameters.AddWithValue("@gender",
                            string.IsNullOrEmpty(t_gender) ? "M" : t_gender.ToUpper());
                        command.Parameters.AddWithValue("@phone",
                            string.IsNullOrEmpty(t_phone) ? DBNull.Value : t_phone);
                        command.Parameters.AddWithValue("@email", t_email);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Teacher added successfully!");
                            // Clear fields
                            TeacherNametextBox.Text = "";
                            TeacherGendertextBox.Text = "";
                            TeacherPhonetextBox.Text = "";
                            TeacherEmailtextBox.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Failed to add teacher");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627) // Unique constraint violation
                    {
                        MessageBox.Show("This email is already registered");
                    }
                    else
                    {
                        MessageBox.Show("Database error: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void teacher_Load(object sender, EventArgs e)
        {

        }
    }
}
