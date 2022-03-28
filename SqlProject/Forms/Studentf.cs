using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlProject
{
    public partial class Studentf : Form
    {
        public Studentf()
        {

            InitializeComponent();
            StdName.Text = MainApp.UserName.ToUpper();
        }

        private void Studentf_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            Application.Exit();
        }

        private void Studentf_Load(object sender, EventArgs e)
        {

        }

        private void StartExam_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainApp.examForm = new Examf(17);
            MainApp.examForm.Show();
        }
    }
}
