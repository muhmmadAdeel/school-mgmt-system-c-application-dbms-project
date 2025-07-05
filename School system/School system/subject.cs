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
    public partial class subject : Form
    {
        public subject()
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

                    // Query to get assignment details with student and course information
                    string selectQuery = @"
                SELECT 
                    ca.course_id AS [Course ID],
                    c.course_name AS [Course Name],
                    ca.student_id AS [Student ID],
                    s.student_name AS [Student Name]
                FROM 
                    course_assign ca
                    INNER JOIN student s ON ca.student_id = s.student_id
                    INNER JOIN course c ON ca.course_id = c.course_id
                ORDER BY 
                    c.course_name, s.student_name";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                        SubjectDataGridView.DataSource = dataTable;

                        // Configure DataGridView appearance
                        SubjectDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        SubjectDataGridView.AllowUserToAddRows = false;
                        SubjectDataGridView.ReadOnly = true;
                        SubjectDataGridView.RowHeadersVisible = false;

                        // Format column widths
                        SubjectDataGridView.Columns["Course ID"].Width = 80;
                        SubjectDataGridView.Columns["Course Name"].Width = 200;
                        SubjectDataGridView.Columns["Student ID"].Width = 80;
                        SubjectDataGridView.Columns["Student Name"].Width = 150;

                        // Enable row selection
                        SubjectDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                        // Optional: Add alternating row colors
                        SubjectDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error while loading assignments:\n" + ex.Message,
                                  "Error",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while loading assignments:\n" + ex.Message,
                                  "Error",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                }
            }
        }

        private void DeleteBtn_Click(object? sender, EventArgs e)
        {
            // Show input dialog to get assignment ID
            string assignmentId = Microsoft.VisualBasic.Interaction.InputBox(
                "Please enter the Assignment ID you want to delete:",
                "Delete Assignment",
                "",
                -1, -1);

            if (string.IsNullOrEmpty(assignmentId))
            {
                MessageBox.Show("No Assignment ID entered. Operation cancelled.");
                return;
            }

            // Validate assignment ID format
            if (!int.TryParse(assignmentId, out int assignId))
            {
                MessageBox.Show("Invalid Assignment ID format. Please enter a number.");
                return;
            }

            // Confirmation dialog
            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to delete assignment #{assignId}?",
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

                    // Verify the assignment exists
                    if (!RecordExistsDelete(connection, "course_assign", "assignment_id", assignId))
                    {
                        MessageBox.Show("Assignment with this ID does not exist.");
                        return;
                    }

                    // Perform the deletion
                    string deleteQuery = "DELETE FROM course_assign WHERE assignment_id = @assignId";

                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@assignId", assignId);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Assignment #{assignId} deleted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No assignment was deleted.");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // Helper method to check if a record exists
        private bool RecordExistsDelete(SqlConnection connection, string tableName, string idColumn, int id)
        {
            string query = $"SELECT COUNT(1) FROM {tableName} WHERE {idColumn} = @id";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@id", id);
                return (int)command.ExecuteScalar() > 0;
            }
        }

        private void UpdateBtn_Click(object? sender, EventArgs e)
        {
            // Show input dialog to get assignment ID
            string assignmentId = Microsoft.VisualBasic.Interaction.InputBox(
                "Please enter the Assignment ID you want to update:",
                "Update Assignment",
                "",
                -1, -1); // Default position

            if (string.IsNullOrEmpty(assignmentId))
            {
                MessageBox.Show("No Assignment ID entered. Operation cancelled.");
                return;
            }

            // Validate assignment ID format
            if (!int.TryParse(assignmentId, out int assignId))
            {
                MessageBox.Show("Invalid Assignment ID format. Please enter a number.");
                return;
            }

            // Get the new details from form controls
            string newStudentId = studentIDtextbox.Text;
            string newCourseId = SubjectIDtextBox.Text;

            // Validate new inputs
            if (string.IsNullOrEmpty(newStudentId) || string.IsNullOrEmpty(newCourseId))
            {
                MessageBox.Show("Please enter both Student ID and Course ID");
                return;
            }

            if (!int.TryParse(newStudentId, out int studentId) || !int.TryParse(newCourseId, out int courseId))
            {
                MessageBox.Show("Invalid ID format. Please enter numeric values.");
                return;
            }

            db db = new db();
            string connectionString = db.get_db();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Verify the assignment exists
                    if (!RecordExistsUpdate(connection, "course_assign", "assignment_id", assignId))
                    {
                        MessageBox.Show("Assignment with this ID does not exist.");
                        return;
                    }

                    // Verify the new student exists
                    if (!RecordExistsUpdate(connection, "student", "student_id", studentId))
                    {
                        MessageBox.Show("New Student ID does not exist.");
                        return;
                    }

                    // Verify the new course exists
                    if (!RecordExistsUpdate(connection, "course", "course_id", courseId))
                    {
                        MessageBox.Show("New Course ID does not exist.");
                        return;
                    }

                    // Check if the new assignment would be a duplicate
                    if (AssignmentExistsUpdate(connection, courseId, studentId))
                    {
                        MessageBox.Show("This student is already assigned to this course.");
                        return;
                    }

                    // Confirmation dialog
                    DialogResult confirm = MessageBox.Show(
                        $"Update assignment #{assignId} to:\nStudent: {studentId}\nCourse: {courseId}",
                        "Confirm Update",
                        MessageBoxButtons.YesNo);

                    if (confirm != DialogResult.Yes)
                    {
                        return;
                    }

                    // Perform the update
                    string updateQuery = @"
                UPDATE course_assign 
                SET course_id = @courseId, 
                    student_id = @studentId 
                WHERE assignment_id = @assignId";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@courseId", courseId);
                        command.Parameters.AddWithValue("@studentId", studentId);
                        command.Parameters.AddWithValue("@assignId", assignId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Assignment updated successfully!");
                            // Clear fields
                            studentIDtextbox.Text = "";
                            SubjectIDtextBox.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("No changes were made to the assignment.");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // Reuse these helper methods from previous implementation
        private bool RecordExistsUpdate(SqlConnection connection, string tableName, string idColumn, int id)
        {
            string query = $"SELECT COUNT(1) FROM {tableName} WHERE {idColumn} = @id";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@id", id);
                return (int)command.ExecuteScalar() > 0;
            }
        }

        private bool AssignmentExistsUpdate(SqlConnection connection, int courseId, int studentId)
        {
            string query = "SELECT COUNT(1) FROM course_assign WHERE course_id = @courseId AND student_id = @studentId";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@courseId", courseId);
                command.Parameters.AddWithValue("@studentId", studentId);
                return (int)command.ExecuteScalar() > 0;
            }
        }

        private void Newbtn_Click(object? sender, EventArgs e)
        {
            string student_id = studentIDtextbox.Text;
            string course_id = SubjectIDtextBox.Text;

            // Validate inputs
            if (string.IsNullOrEmpty(student_id) || string.IsNullOrEmpty(course_id))
            {
                MessageBox.Show("Please enter both Student ID and Course ID");
                return;
            }

            // Convert to integers (with error handling)
            if (!int.TryParse(student_id, out int studentId) || !int.TryParse(course_id, out int courseId))
            {
                MessageBox.Show("Invalid ID format. Please enter numeric values.");
                return;
            }

            db db = new db();
            string connectionString = db.get_db();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Check if student exists
                    if (!RecordExistsNew(connection, "student", "student_id", studentId))
                    {
                        MessageBox.Show("Student with this ID does not exist.");
                        return;
                    }

                    // Check if course exists
                    if (!RecordExistsNew(connection, "course", "course_id", courseId))
                    {
                        MessageBox.Show("Course with this ID does not exist.");
                        return;
                    }

                    // Check if assignment already exists
                    if (AssignmentExistsNew(connection, courseId, studentId))
                    {
                        MessageBox.Show("This student is already assigned to this course.");
                        return;
                    }

                    // Insert new assignment
                    string insertQuery = @"
                INSERT INTO course_assign (course_id, student_id)
                VALUES (@courseId, @studentId)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@courseId", courseId);
                        command.Parameters.AddWithValue("@studentId", studentId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Course assigned successfully!");
                            // Optionally clear the fields
                            studentIDtextbox.Text = "";
                            SubjectIDtextBox.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Failed to assign course.");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // Helper method to check if a record exists
        private bool RecordExistsNew(SqlConnection connection, string tableName, string idColumn, int id)
        {
            string query = $"SELECT COUNT(1) FROM {tableName} WHERE {idColumn} = @id";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@id", id);
                return (int)command.ExecuteScalar() > 0;
            }
        }

        // Helper method to check if assignment already exists
        private bool AssignmentExistsNew(SqlConnection connection, int courseId, int studentId)
        {
            string query = "SELECT COUNT(1) FROM course_assign WHERE course_id = @courseId AND student_id = @studentId";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@courseId", courseId);
                command.Parameters.AddWithValue("@studentId", studentId);
                return (int)command.ExecuteScalar() > 0;
            }
        }

        private void subject_Load(object sender, EventArgs e)
        {

        }
    }
}
