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
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ReportDataSource src = new ReportDataSource("r1_student_info_for_each_department_Result");

            //reportViewer1.LocalReport.ReportEmbeddedResource = "r1_student_info_for_each_department_Result.rdl";
            //reportViewer1.LocalReport.DataSources.Clear();
            //reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("r1_student_info_for_each_department_Result.rdl"));
            //var binding = new BindingSource();
            //binding.DataSource = new r1_student_info_for_each_department_Result();
            //reportViewer1.Reset();
            //reportViewer1.LocalReport.DataSources.Add(new ReportDataSource(Name, binding));
            //reportViewer1.LocalReport.ReportEmbeddedResource = "r1_student_info_for_each_department_Result.rdl";
            //reportViewer1.RefreshReport();

        }
    }
}
