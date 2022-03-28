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
    public partial class QuestionsControl : UserControl
    {
       
        public QuestionsControl(int qNo, string qDesc, string Ans1, string Ans2, string Ans3)
        {
            InitializeComponent();
            QuestNo.Text = $"{qNo})";
            QuesDesc.Text = qDesc;
            label1.Text = Ans1;
            label2.Text = Ans2;
            label3.Text = Ans3;
            if (Ans3 == null)
            {
                label3.Visible = false;
                radioButton3.Visible = false;
                this.Size = new Size(868, 100);
            }
        }
       
    }
}
