using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlProject.Forms
{
    public partial class Admin : Form
    {
        int reportFlag = 0;
        public Admin()
        {
            InitializeComponent();
        }


        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

            this.reportViewer3.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (reportFlag != 0)
            {

                this.reportViewer3.ServerReport.ReportPath = "/ExaminationSystemReports/r1_student_info_for_each_department";
                this.reportViewer3.ServerReport.Refresh();
                this.reportViewer3.RefreshReport();

            }
            else
            {
                reportFlag = 1;
                MessageBox.Show("Please Diploy the Reports to yourlocal Host and press again\n OR preview in local format ");
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (reportFlag != 0)
            {

                this.reportViewer3.ServerReport.ReportPath = "/ExaminationSystemReports/r2_student_grades";
                this.reportViewer3.ServerReport.Refresh();
                this.reportViewer3.RefreshReport();

            }
            else
            {
                reportFlag = 1;
                MessageBox.Show("Please Diploy the Reports to yourlocal Host and press again\n OR preview in local format ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (reportFlag != 0)
            {

                this.reportViewer3.ServerReport.ReportPath = "/ExaminationSystemReports/r3_instructor_courses";
                this.reportViewer3.ServerReport.Refresh();
                this.reportViewer3.RefreshReport();

            }
            else
            {
                reportFlag = 1;
                MessageBox.Show("Please Diploy the Reports to yourlocal Host and press again\n OR preview in local format ");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (reportFlag != 0)
            {

                this.reportViewer3.ServerReport.ReportPath = "/ExaminationSystemReports/r4_course_topics";
                this.reportViewer3.ServerReport.Refresh();
                this.reportViewer3.RefreshReport();

            }
            else
            {
                reportFlag = 1;
                MessageBox.Show("Please Diploy the Reports to yourlocal Host and press again\n OR preview in local format ");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (reportFlag != 0)
            {

                this.reportViewer3.ServerReport.ReportPath = "/ExaminationSystemReports/r5_exam_questions";
                this.reportViewer3.ServerReport.Refresh();
                this.reportViewer3.RefreshReport();

            }
            else
            {
                reportFlag = 1;
                MessageBox.Show("Please Diploy the Reports to yourlocal Host and press again\n OR preview in local format ");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (reportFlag != 0)
            {

                this.reportViewer3.ServerReport.ReportPath = "/ExaminationSystemReports/r6_student_exam";
                this.reportViewer3.ServerReport.Refresh();
                this.reportViewer3.RefreshReport();

            }
            else
            {
                reportFlag = 1;
                MessageBox.Show("Please Diploy the Reports to yourlocal Host and press again\n OR preview in local format ");
            }
        }
    }
}
