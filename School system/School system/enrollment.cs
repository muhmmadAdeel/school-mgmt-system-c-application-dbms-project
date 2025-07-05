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
    public partial class enrollment : Form
    {
        public enrollment()
        {
            InitializeComponent();
            Newbtn.Click += Newbtn_Click;
            updateBtn.Click += UpdateBtn_Click;
            deleteBtn.Click += DeleteBtn_Click;
            Displaybtn.Click += Displaybtn_Click;
        }

        private void Displaybtn_Click(object? sender, EventArgs e)
        {
            // Connection string (update it based on your database server and name)
            db db = new db();
            string connectionString = db.get_db();

            // SQL query to fetch all records from the enrollment table
            string query = "SELECT * FROM enrollment";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Assuming your DataGridView control is named "EnrollmentDataGridView"
                    DataGridView.DataSource = dt;

                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DeleteBtn_Click(object? sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrEmpty(EIDtextBox.Text))
            {
                MessageBox.Show("Please enter an Enrollment ID");
                return;
            }

            if (!int.TryParse(EIDtextBox.Text, out int enrollmentId))
            {
                MessageBox.Show("Enrollment ID must be a valid number");
                return;
            }

            // Confirmation dialog
            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to delete enrollment #{enrollmentId}?",
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

                    // First check if enrollment exists and get details for confirmation
                    string checkQuery = @"
                SELECT e.enrollment_id, s.student_name, c.course_name 
                FROM enrollment e
                JOIN student s ON e.student_id = s.student_id
                JOIN course c ON e.course_id = c.course_id
                WHERE e.enrollment_id = @eid";

                    string studentName = "";
                    string courseName = "";

                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@eid", enrollmentId);
                        using (SqlDataReader reader = checkCmd.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                MessageBox.Show("Enrollment with this ID does not exist");
                                return;
                            }

                            reader.Read();
                            studentName = reader["student_name"].ToString();
                            courseName = reader["course_name"].ToString();
                        }
                    }

                    // Final confirmation with details
                    confirm = MessageBox.Show(
                        $"Delete this enrollment?\n\nStudent: {studentName}\nCourse: {courseName}",
                        "Final Confirmation",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (confirm != DialogResult.Yes)
                    {
                        return;
                    }

                    // Perform deletion
                    string deleteQuery = "DELETE FROM enrollment WHERE enrollment_id = @eid";

                    using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, connection))
                    {
                        deleteCmd.Parameters.AddWithValue("@eid", enrollmentId);
                        int rowsAffected = deleteCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Enrollment #{enrollmentId} deleted successfully!");
                            EIDtextBox.Text = ""; // Clear the input field
                        }
                        else
                        {
                            MessageBox.Show("No enrollment was deleted");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547) // Foreign key constraint violation
                    {
                        MessageBox.Show("Cannot delete this enrollment because it's referenced in other records");
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
            string EID = EIDtextBox.Text;
            string newGrade = GradetextBox.Text;
            string newStatus = StatustextBox.Text;

            // Validate inputs
            if (string.IsNullOrEmpty(EID))
            {
                MessageBox.Show("Please enter an Enrollment ID");
                return;
            }

            if (!int.TryParse(EID, out int enrollmentId))
            {
                MessageBox.Show("Enrollment ID must be a number");
                return;
            }

            // Validate grade if provided
            if (!string.IsNullOrEmpty(newGrade) && newGrade.Length > 2)
            {
                MessageBox.Show("Grade must be 1-2 characters (e.g., A, B+, F)");
                return;
            }

            // Validate status if provided
            if (!string.IsNullOrEmpty(newStatus) &&
                !(newStatus.Equals("Active", StringComparison.OrdinalIgnoreCase) ||
                  newStatus.Equals("Completed", StringComparison.OrdinalIgnoreCase) ||
                  newStatus.Equals("Dropped", StringComparison.OrdinalIgnoreCase) ||
                  newStatus.Equals("Withdrawn", StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Status must be: Active, Completed, Dropped, or Withdrawn");
                return;
            }

            db db = new db();
            string connectionString = db.get_db();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Check if enrollment exists
                    string checkQuery = "SELECT student_id, course_id, grade, status FROM enrollment WHERE enrollment_id = @eid";
                    DataTable enrollmentData = new DataTable();

                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@eid", enrollmentId);
                        SqlDataAdapter adapter = new SqlDataAdapter(checkCmd);
                        adapter.Fill(enrollmentData);

                        if (enrollmentData.Rows.Count == 0)
                        {
                            MessageBox.Show("Enrollment with this ID does not exist");
                            return;
                        }
                    }

                    // Get current values if new values are empty
                    DataRow row = enrollmentData.Rows[0];
                    string currentGrade = row["grade"].ToString();
                    string currentStatus = row["status"].ToString();

                    string finalGrade = string.IsNullOrEmpty(newGrade) ? currentGrade : newGrade;
                    string finalStatus = string.IsNullOrEmpty(newStatus) ? currentStatus : newStatus;

                    // Confirmation dialog
                    DialogResult confirm = MessageBox.Show(
                        $"Update Enrollment #{enrollmentId} to:\nGrade: {finalGrade}\nStatus: {finalStatus}",
                        "Confirm Update",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (confirm != DialogResult.Yes)
                    {
                        return;
                    }

                    // Update enrollment
                    string updateQuery = @"
                UPDATE enrollment 
                SET grade = @grade, 
                    status = @status 
                WHERE enrollment_id = @eid";

                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, connection))
                    {
                        updateCmd.Parameters.AddWithValue("@eid", enrollmentId);
                        updateCmd.Parameters.AddWithValue("@grade",
                            string.IsNullOrEmpty(finalGrade) ? DBNull.Value : (object)finalGrade.ToUpper());
                        updateCmd.Parameters.AddWithValue("@status", finalStatus);

                        int rowsAffected = updateCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Enrollment updated successfully!");
                            // Clear fields
                            EIDtextBox.Text = "";
                            GradetextBox.Text = "";
                            StatustextBox.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("No changes were made to the enrollment");
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

        private void Newbtn_Click(object? sender, EventArgs e)
        {
            // Get input values
            string studentId = StudentIDtextBox.Text;
            string courseId = CourseIDtextBox.Text;
            string grade = GradetextBox.Text;

            // Validate inputs
            if (string.IsNullOrEmpty(studentId) || string.IsNullOrEmpty(courseId))
            {
                MessageBox.Show("Student ID and Course ID are required!");
                return;
            }

            if (!int.TryParse(studentId, out int sId) || !int.TryParse(courseId, out int cId))
            {
                MessageBox.Show("Student ID and Course ID must be numbers!");
                return;
            }

            // Validate grade if provided
            if (!string.IsNullOrEmpty(grade) && grade.Length > 2)
            {
                MessageBox.Show("Grade must be 1-2 characters (e.g., A, B+, F)");
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
                    if (!RecordExists(connection, "student", "student_id", sId))
                    {
                        MessageBox.Show("Student with this ID does not exist!");
                        return;
                    }

                    // Check if course exists
                    if (!RecordExists(connection, "course", "course_id", cId))
                    {
                        MessageBox.Show("Course with this ID does not exist!");
                        return;
                    }

                    // Check if enrollment already exists
                    if (EnrollmentExists(connection, sId, cId))
                    {
                        MessageBox.Show("This student is already enrolled in this course!");
                        return;
                    }

                    // Insert new enrollment
                    string insertQuery = @"
                INSERT INTO enrollment (student_id, course_id, grade)
                VALUES (@studentId, @courseId, @grade)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@studentId", sId);
                        command.Parameters.AddWithValue("@courseId", cId);
                        command.Parameters.AddWithValue("@grade",
                            string.IsNullOrEmpty(grade) ? DBNull.Value : (object)grade.ToUpper());

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Enrollment added successfully!");
                            // Clear fields
                            StudentIDtextBox.Text = "";
                            CourseIDtextBox.Text = "";
                            GradetextBox.Text = "";
                        }
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547) // Foreign key violation
                    {
                        MessageBox.Show("Invalid Student ID or Course ID");
                    }
                    else if (ex.Number == 2627) // Unique constraint
                    {
                        MessageBox.Show("This enrollment already exists");
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

        // Helper method to check if record exists
        private bool RecordExists(SqlConnection connection, string table, string idColumn, int id)
        {
            string query = $"SELECT COUNT(1) FROM {table} WHERE {idColumn} = @id";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@id", id);
                return (int)command.ExecuteScalar() > 0;
            }
        }

        // Helper method to check if enrollment exists
        private bool EnrollmentExists(SqlConnection connection, int studentId, int courseId)
        {
            string query = "SELECT COUNT(1) FROM enrollment WHERE student_id = @sId AND course_id = @cId";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@sId", studentId);
                command.Parameters.AddWithValue("@cId", courseId);
                return (int)command.ExecuteScalar() > 0;
            }
        }

        private void enrollment_Load(object sender, EventArgs e)
        {

        }
    }
}
