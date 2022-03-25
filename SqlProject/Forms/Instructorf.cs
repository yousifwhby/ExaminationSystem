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
    public partial class Instructorf : Form
    {
        public Instructorf()
        {
            InitializeComponent();
        }

        private void Instructorf_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Instructorf_Load(object sender, EventArgs e)
        {
            //var curs = MainApp.entity.courses.Select(s => s);
            //foreach(var c in curs)
            //{

            //comboBox1.Items.Add(c.course_name);
            //}
        }
    }
}
