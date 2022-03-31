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
    public partial class Examf : Form
    {
        ClassExam exam;
        ClassQuestion q;
        ClassChoice c;
        int ExamID;
        public Examf(int eid)
        {
            InitializeComponent();
            
            this.ExamID = eid;
           
        }

        private void examF_Load(object sender, EventArgs e)
        {
            exam = new ClassExam();
            
            var exam_Questions = MainApp.entity.Students_exams_questions.Where(eq => eq.student_ID == MainApp.UserID && eq.exam_ID == ExamID)
                .Select(eq => eq);
            QuestionsControl ques;
            int i = 0;
            foreach (var exam_Question in exam_Questions)
            {
                q = new ClassQuestion();
                var question = MainApp.entity.questions.Where(eq => eq.question_ID == exam_Question.qustion_ID)
                    .Select(eq => eq).FirstOrDefault();
                var choices = MainApp.entity.choices.Where(qAns => qAns.question_ID == exam_Question.qustion_ID)
                    .Select(qAns => qAns);
                
                q.qID = question.question_ID;
                q.qDesc = question.qusetion_desc;

                
                int j = 0;
                foreach (var choice in choices)
                {
                    c = new ClassChoice();
                    c.cID = choice.choice_ID;
                    c.cDesc = choice.choice_description;
                    q.choices[j] = c;
                    j++;
                }
                exam.questions[i] = q;
               
                ques = new QuestionsControl(i + 1, exam.questions[i].qDesc, exam.questions[i].choices[0].cDesc, exam.questions[i].choices[1].cDesc, exam.questions[i].choices[2] == null ? null : exam.questions[i].choices[2].cDesc);
                flowLayoutQuestion.Controls.Add(ques);
                i++;
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Do You Want to Submit Your Answers?","Submitting",MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                int i = 0;
                foreach (var q in flowLayoutQuestion.Controls)
                {
                    int checkedID = 0;
                    string CheckedAns = "";
                    CheckedAns = ((QuestionsControl)q).radioButton1.Checked == true ? exam.questions[i].choices[0].cDesc : CheckedAns;
                    CheckedAns = ((QuestionsControl)q).radioButton2.Checked == true ? exam.questions[i].choices[1].cDesc : CheckedAns;
                    CheckedAns = ((QuestionsControl)q).radioButton3.Checked == true ? exam.questions[i].choices[2].cDesc : CheckedAns;
                    
                    
                    exam.questions[i].studentChoiceDesc = CheckedAns;
                    i++;
                }
                for (int k = 0; k < 10; k++)
                {
                    MainApp.entity.exam_answers(ExamID, MainApp.UserID, k + 1, exam.questions[k].studentChoiceDesc);
                }
                MainApp.entity = new SQLProjectEntities3();
                MainApp.entity.correctExam(ExamID, MainApp.UserID);
                MainApp.entity = new SQLProjectEntities3();
                MessageBox.Show("submitted!");
                MessageBox.Show($"{exam.questions[0].studentChoiceDesc} \n,{exam.questions[1].studentChoiceDesc} \n ,{exam.questions[2].studentChoiceDesc} \n ,{exam.questions[3].studentChoiceDesc} \n,{exam.questions[4].studentChoiceDesc}\n,{exam.questions[5].studentChoiceDesc} \n ,{exam.questions[6].studentChoiceDesc} \n ,{exam.questions[7].studentChoiceDesc} \n ,{exam.questions[8].studentChoiceDesc} \n ,{exam.questions[9].studentChoiceDesc}");
                MainApp.studentForm.Studentf_Load(null, null);
                MainApp.examForm.Close();
            }
        }

        
        private void examF_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainApp.studentForm.Show();
        }

    }
}


