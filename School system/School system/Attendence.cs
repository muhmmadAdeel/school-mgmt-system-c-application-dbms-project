using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_system
{
    public partial class Attendence : Form
    {
        public Attendence()
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
            string ConnectionString = db.get_db();

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    string query = "SELECT * FROM attendance";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Bind data to DataGridView
                    DataGridView.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading attendance data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DeleteBtn_Click(object? sender, EventArgs e)
        {
            db db = new db();
            string ConnectionString = db.get_db();
            

            if (String.IsNullOrEmpty(AIDDtextBox.Text))
            {
                MessageBox.Show("please enter Attendence ID ");
                return;
            }
            int AID = int.Parse(AIDDtextBox.Text);
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    string query = "delete from attendence where AID = @AID";
                    using (SqlCommand deleteCmd = new SqlCommand(query, conn))
                    {
                        deleteCmd.Parameters.AddWithValue("@teacherId", AID);

                        int rowsAffected = deleteCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Successfully deleted ID: {AID}");
                            AIDDtextBox.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("No teacher was deleted.");
                        }
                    }
                }
                {

                }
            }
            catch (Exception ex) {
                MessageBox.Show
                    ("invalid ");
                    return ;
            }

        }

        private void UpdateBtn_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AIDDtextBox.Text))
            {
                MessageBox.Show("Please enter Attendance ID (AID) to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int AID = int.Parse(AIDDtextBox.Text.Trim());
            string studentID = SIDTextBox.Text.Trim();
            string description = DescriptiontextBox.Text.Trim();
            DateTime selectedDate = dateTimePicker1.Value;

            // Validation
            if (string.IsNullOrEmpty(studentID) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please fill in all fields (Student ID, Description).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            db db = new db();
            string connectionString = db.get_db();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Step 1: Check if record exists
                    string checkQuery = "SELECT COUNT(*) FROM attendance WHERE AID = @AID";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@AID", AID);

                    int count = (int)checkCmd.ExecuteScalar();

                    if (count == 0)
                    {
                        MessageBox.Show("Attendance record not found with the provided AID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Step 2: Update the record
                    string updateQuery = @"
                UPDATE attendance
                SET studentID = @studentID,
                    description = @description,
                    date = @date
                WHERE AID = @AID";

                    SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@studentID", int.Parse(studentID));
                    updateCmd.Parameters.AddWithValue("@description", description);
                    updateCmd.Parameters.AddWithValue("@date", selectedDate);
                    updateCmd.Parameters.AddWithValue("@AID", AID);

                    int rowsAffected = updateCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Attendance record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Update failed. No changes were made.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating attendance record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Newbtn_Click(object? sender, EventArgs e)
        {
            // Collect input values
            string studentID = SIDTextBox.Text.Trim();
            string description = DescriptiontextBox.Text.Trim();
            DateTime selectedDate = dateTimePicker1.Value;

            // Validation
            if (string.IsNullOrEmpty(studentID) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Connection string (update with your DB server and name)
            db db   = new db();
            string connectionString = db.get_db();

            // SQL insert query
            string insertQuery = @"
        INSERT INTO attendance (studentID, description, date)
        VALUES (@studentID, @description, @date)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@studentID", int.Parse(studentID));
                        cmd.Parameters.AddWithValue("@description", description);
                        cmd.Parameters.AddWithValue("@date", selectedDate);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Attendance record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding attendance: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Attendence_Load(object sender, EventArgs e)
        {

        }
    }
}
