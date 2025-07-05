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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            db db = new db();
            string connectionString = db.get_db();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Total Students
                    SqlCommand studentCmd = new SqlCommand("SELECT COUNT(*) FROM student", conn);
                    int totalStudents = (int)studentCmd.ExecuteScalar();
                    totalStudentLabel.Text = "Students : " + totalStudents;

                    // Total Subjects
                    SqlCommand subjectCmd = new SqlCommand("SELECT COUNT(*) FROM course", conn);
                    int totalSubjects = (int)subjectCmd.ExecuteScalar();
                    TotalSubjectsLabel.Text = "Subjects : " + totalSubjects;

                    // Total Teachers
                    SqlCommand teacherCmd = new SqlCommand("SELECT COUNT(*) FROM teacher", conn);
                    int totalTeachers = (int)teacherCmd.ExecuteScalar();
                    TotalTeacherLabel.Text = "Teachers : " + totalTeachers;

                    // Total Enrollments
                    SqlCommand enrollmentCmd = new SqlCommand("SELECT COUNT(*) FROM enrollment", conn);
                    int totalEnrollments = (int)enrollmentCmd.ExecuteScalar();
                    TotalEnrollmentLabel.Text = "Enrollments : " + totalEnrollments;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load dashboard data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
