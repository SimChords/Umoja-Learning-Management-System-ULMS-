using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ULMSWinFormsApp.Models;

namespace ULMSWinFormsApp.Forms
{
    public partial class FrmCourseEnrollment : Form
    {
        public FrmCourseEnrollment()
        {
            InitializeComponent();
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            try
            {

                if (String.IsNullOrWhiteSpace(txtEnrollStudentId.Text) ||
                    string.IsNullOrWhiteSpace(txtEnrollStudentName.Text) ||
                    string.IsNullOrWhiteSpace(cmbCourse.Text) ||
                    string.IsNullOrWhiteSpace(cmbCourse.Text))
                {
                    MessageBox.Show("Please complete all enrollment fileds.");
                    return;
                }

                // Intentional weak business-rule validation for testing purposes
                Enrollment enrollment = new Enrollment
                {
                    StudentId = txtEnrollStudentId.Text,
                    StudentName = txtEnrollStudentName.Text,
                    CourseName = cmbCourse.Text,
                    Semester = cmbSemester.Text
                };

                txtEnrollmentOutput.Text =
                    "Enrollment completed successfully!" + Environment.NewLine +
                    "Student ID: " + enrollment.StudentId + Environment.NewLine +
                    "Student Name: " + enrollment.StudentName + Environment.NewLine +
                    "Course: " + enrollment.CourseName + Environment.NewLine +
                    "Semester: " + enrollment.Semester;
            }
            catch
            {
                MessageBox.Show("An error occured during enrollment.");
            }
        }

        private void btnClearEnrollment_Click(object sender, EventArgs e)
        {
            txtEnrollStudentId.Clear();
            txtEnrollStudentName.Clear();
            cmbCourse.SelectedIndex = -1;
            cmbSemester.SelectedIndex = -1;
            txtEnrollmentOutput.Clear();
            txtEnrollStudentId.Focus();
        }

        private void btnBackEnrollment_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
