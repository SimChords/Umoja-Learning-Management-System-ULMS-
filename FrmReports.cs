using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace ULMSWinFormsApp.Forms
{
    public partial class FrmReports : Form
    {
        public FrmReports()
        {
            InitializeComponent();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            try
            { 
            //  Fixed
            string reportType = cmbReportType.Text;
            string studentId = txtReportStudentId.Text;

            //     Fixed
            Thread.Sleep(4000);

            StringBuilder report = new StringBuilder();

            report.AppendLine("===== ULMS REPORT =====");
            report.AppendLine("Report Type: " + reportType);
            report.AppendLine("Student ID Filter: " + studentId);
            report.AppendLine("Generated On: " + DateTime.Now);
            report.AppendLine();

            if (reportType == "Student Summary Report")
            {
                report.AppendLine("Student Name: John Doe");
                report.AppendLine("Programme: Software Engineering");
                report.AppendLine("Status: Active");
            }
            else if (reportType == "Marks Report")
            {

                int s1 = 0;
                int s2 = 0;
                int s3 = 0;

                int total = s1 + s2 + s3;
                double average = total / 3.0;

                report.AppendLine("Subject 1: " + s1);
                report.AppendLine("Subject 2: " + s2);
                report.AppendLine("Subject 3: " + s3);
                report.AppendLine("Total: " + total);
                report.AppendLine("Average: " + average.ToString("0.00"));
            }
            else if (reportType == "Enrollment Report")
            {
                report.AppendLine("Course 1: Programming 1");
                report.AppendLine("Course 2: Database Systems");
                report.AppendLine("Semester: Semester 1");
            }
            else
            {
                report.AppendLine("No report type selected.");
            }

            txtReportOutput.Text = report.ToString();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error generating report: " + ex.Message);
        }
}

        private void btnClearReport_Click(object sender, EventArgs e)
        {
            cmbReportType.SelectedIndex = -1;
            txtReportStudentId.Clear();
            txtReportOutput.Clear();
            txtReportStudentId.Focus();
        }

        private void btnBackReport_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}
