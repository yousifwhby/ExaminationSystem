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
        KeyValuePair<int, string> SelectedCourse;
        int examID;

        public Studentf()
        {

            InitializeComponent();
            StdName.Text = MainApp.UserName.ToUpper();
            label3.Text = DateTime.Today.ToString("d");

        }

        private void Studentf_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            Application.Exit();
        }

        public void Studentf_Load(object sender, EventArgs e)
        {
            Courses.Items.Clear();
            Exams.Items.Clear();
            Courses.Text = Exams.Text = "";
            fillExamsTab();
            fillCourseTab();


        }

        private void StartExam_btn_Click(object sender, EventArgs e)
        {
            if(Exams.Text != null && Exams.Text !=string.Empty)
            {
            examID = int.Parse(Exams.Text);

            MainApp.studentForm.Hide();
            MainApp.examForm = new Examf(examID);
            MainApp.examForm.Show();
            }
            else
            {
                MessageBox.Show("Choose an exam or ask ur instruactor to assig exam to You");
            }
        }

        private void Courses_SelectedIndexChanged(object sender, EventArgs e)
        {
            Exams.Items.Clear();
            SelectedCourse = (KeyValuePair<int, string>)Courses.SelectedItem;
           // MessageBox.Show(SelectedCourse.Key.ToString());

            var ex = from es in MainApp.entity.student_exam
                     join ee in MainApp.entity.exams on es.exam_ID equals ee.exam_ID
                     where ee.course_ID == SelectedCourse.Key
                     where es.student_ID == MainApp.UserID
                     where es.exam_grade == null
                     select es;
            if(ex != null)
            {
                foreach (var EX in ex)
                {
                    Exams.Items.Add(EX.exam_ID);
                }
            }
            else
            {
                Exams.Items.Add("No Exam Availabe");
                Exams.Enabled = false;
                Exams.SelectedIndex = 0;
            }


        }
        public void fillExamsTab()
        {             
                foreach (var c in MainApp.std_us.courses)
                {
                 Courses.Items.Add(new KeyValuePair<int, string>(c.course_ID, c.course_name));
                }
                Courses.DisplayMember = "Value";
                Courses.ValueMember = "Key";
            if( Courses.Items.Count >0)
            {
                Courses.SelectedIndex=0;
            }
            

        }

        public void fillCourseTab()
        {
            var studentgrades = from g in MainApp.entity.student_exam
                                join c in MainApp.entity.exams on g.exam_ID equals c.exam_ID
                                join courName in MainApp.entity.courses on c.course_ID equals courName.course_ID
                                where g.student_ID == MainApp.UserID
                                select new { courName.course_name, g.exam_ID, g.exam_grade };
            StudentInfo_GV.Rows.Clear();
            foreach (var item in studentgrades)
            {
                string grade = item.exam_grade != null ? item.exam_grade.ToString() : "Exam is available ";
               StudentInfo_GV.Rows.Add(item.course_name, item.exam_ID,grade);
            }
        }
    }
}
