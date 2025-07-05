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
    public partial class student : Form
    {
        public student()
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

                    string selectQuery = "SELECT student_id, student_name, DOB, gender, phoneNo, email FROM student";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                        dataGridView.DataSource = dataTable;

                        // Optional: Format the DataGridView columns
                        if (dataGridView.Columns.Count > 0)
                        {
                            dataGridView.Columns["student_id"].HeaderText = "Student ID";
                            dataGridView.Columns["student_name"].HeaderText = "Name";
                            dataGridView.Columns["DOB"].HeaderText = "Date of Birth";
                            dataGridView.Columns["gender"].HeaderText = "Gender";
                            dataGridView.Columns["phoneNo"].HeaderText = "Phone Number";
                            dataGridView.Columns["email"].HeaderText = "Email";

                            // Set column widths
                            dataGridView.Columns["student_id"].Width = 80;
                            dataGridView.Columns["student_name"].Width = 150;
                            dataGridView.Columns["DOB"].Width = 100;
                            dataGridView.Columns["gender"].Width = 60;
                            dataGridView.Columns["phoneNo"].Width = 120;
                            dataGridView.Columns["email"].Width = 180;

                            // Make the grid read-only
                            dataGridView.ReadOnly = true;

                            // Enable row headers but make them invisible
                            dataGridView.RowHeadersVisible = false;

                            // Enable alternating row colors for better readability
                            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred while loading data: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void DeleteBtn_Click(object? sender, EventArgs e)
        {
            string studentID = studentIDtextbox.Text;

            // Validate student ID
            if (string.IsNullOrEmpty(studentID))
            {
                MessageBox.Show("Please enter a Student ID");
                return;
            }

            // Ask for confirmation before deleting
            DialogResult confirmResult = MessageBox.Show(
                $"Are you sure you want to delete student with ID: {studentID}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmResult != DialogResult.Yes)
            {
                return; // User cancelled the delete operation
            }

            db db = new db();
            string connectionString = db.get_db();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // First check if student exists
                    string checkQuery = "SELECT COUNT(1) FROM student WHERE student_id = @studentID";

                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@studentID", studentID);
                        int studentExists = (int)checkCommand.ExecuteScalar();

                        if (studentExists == 0)
                        {
                            MessageBox.Show("Student with this ID does not exist.");
                            return;
                        }
                    }

                    // Delete student
                    string deleteQuery = "DELETE FROM student WHERE student_id = @studentID";

                    using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                    {
                        deleteCommand.Parameters.AddWithValue("@studentID", studentID);

                        int rowsAffected = deleteCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student deleted successfully!");
                            // Clear the fields after successful delete
                            studentIDtextbox.Text = "";
                            NametextBox.Text = "";
                            DOBtime.Text = "";
                            GendertextBox.Text = "";
                            PhonetextBox.Text = "";
                            EmailtextBox.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("No student was deleted.");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    // Handle foreign key constraint violation if student is referenced elsewhere
                    if (ex.Number == 547) // Constraint check violation
                    {
                        MessageBox.Show("Cannot delete this student because they are referenced in other records.");
                    }
                    else
                    {
                        MessageBox.Show("An error occurred while deleting: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void UpdateBtn_Click(object? sender, EventArgs e)
        {
            string studentID = studentIDtextbox.Text;
            string student_name = NametextBox.Text;
            string DOB = DOBtime.Text;
            string gender = GendertextBox.Text;
            string phoneNo = PhonetextBox.Text;
            string email = EmailtextBox.Text;
            // Validate student ID
            if (string.IsNullOrEmpty(studentID))
            {
                MessageBox.Show("Please enter a Student ID");
                return;
            }
            if (!string.IsNullOrEmpty(NametextBox.Text) && !string.IsNullOrEmpty(DOBtime.Text) && !string.IsNullOrEmpty(PhonetextBox.Text) && !string.IsNullOrEmpty(EmailtextBox.Text))
            {

            }
            else
            {
                MessageBox.Show("Please enter a Student details");
                return;
            }

            db db = new db();
            string connectionString = db.get_db();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // First check if student exists
                    string checkQuery = "SELECT COUNT(1) FROM student WHERE student_id = @studentID";

                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@studentID", studentID);
                        int studentExists = (int)checkCommand.ExecuteScalar();

                        if (studentExists == 0)
                        {
                            MessageBox.Show("Student with this ID does not exist.");
                            return;
                        }
                    }

                    // Update student details
                    string updateQuery = @"UPDATE student SET 
                                 student_name = @student_name, 
                                 DOB = @DOB, 
                                 gender = @gender, 
                                 phoneNo = @phoneNo, 
                                 email = @email 
                                 WHERE student_id = @studentID";

                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@studentID", studentID);
                        updateCommand.Parameters.AddWithValue("@student_name", student_name);
                        updateCommand.Parameters.AddWithValue("@DOB", DOB);
                        updateCommand.Parameters.AddWithValue("@gender", string.IsNullOrEmpty(gender) ? "M" : gender);
                        updateCommand.Parameters.AddWithValue("@phoneNo", phoneNo);
                        updateCommand.Parameters.AddWithValue("@email", email);

                        int rowsAffected = updateCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student details updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No changes were made to the student record.");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627) // Unique constraint violation (for email)
                    {
                        MessageBox.Show("This email already exists in the system for another student.");
                    }
                    else
                    {
                        MessageBox.Show("An error occurred while updating: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void Newbtn_Click(object? sender, EventArgs e)
        {
            string student_name = NametextBox.Text;
            string DOB = DOBtime.Text;
            string gender = GendertextBox.Text;
            string phoneNo = PhonetextBox.Text;
            string email = EmailtextBox.Text;

            db db = new db();
            string connectionString = db.get_db();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"INSERT INTO student (student_name, DOB, gender, phoneNo, email) 
                             VALUES (@student_name, @DOB, @gender, @phoneNo, @email)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@student_name", student_name);
                        command.Parameters.AddWithValue("@DOB", DOB);
                        command.Parameters.AddWithValue("@gender", string.IsNullOrEmpty(gender) ? "M" : gender);
                        command.Parameters.AddWithValue("@phoneNo", phoneNo);
                        command.Parameters.AddWithValue("@email", email);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student details saved successfully!");
                            // Optionally clear the fields after successful save
                            NametextBox.Text = "";
                            DOBtime.Text = "";
                            GendertextBox.Text = "";
                            PhonetextBox.Text = "";
                            EmailtextBox.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Failed to save student details.");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627) // Unique constraint violation (for email)
                    {
                        MessageBox.Show("This email already exists in the system.");
                    }
                    else
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void student_Load(object sender, EventArgs e)
        {

        }
    }
}
