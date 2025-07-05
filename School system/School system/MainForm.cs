using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_system
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            studentBtn.Click += StudentBtn_Click;
            subjectbtn.Click += Subjectbtn_Click;
            TeacherBtn.Click += TeacherBtn_Click;
           
            EnrollmentBtn.Click += EnrollmentBtn_Click;
            attendenceBtn.Click += AttendenceBtn_Click;
            DashboardBtn.Click += DashboardBtn_Click;
        }

        private void DashboardBtn_Click(object? sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
            
        }

        private void AttendenceBtn_Click(object? sender, EventArgs e)
        {
            Attendence attendence = new Attendence();
            attendence.Show();
        }

        private void EnrollmentBtn_Click(object? sender, EventArgs e)
        {
            enrollment enrollment = new enrollment();   
            enrollment.Show();
        }

        private void TeacherBtn_Click(object? sender, EventArgs e)
        {
            teacher teacher = new teacher();
            teacher.Show();
        }

        private void Subjectbtn_Click(object? sender, EventArgs e)
        {
            subject subject = new subject();    
            subject.Show();
        }

        private void StudentBtn_Click(object? sender, EventArgs e)
        {
            student student = new student();    
            student.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
