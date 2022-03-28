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
            
            var examQuestions = MainApp.entity.Students_exams_questions.Where(eq => eq.student_ID == 2 && eq.exam_ID == ExamID)
                .Select(eq => eq);
            QuestionsControl ques;
            int i = 0;
            foreach (var examQuestion in examQuestions)
            {
                q = new ClassQuestion();
                var question = MainApp.entity.questions.Where(eq => eq.question_ID == examQuestion.qustion_ID)
                    .Select(eq => eq).FirstOrDefault();
                var choices = MainApp.entity.choices.Where(qAns => qAns.choice_ID == examQuestion.qustion_ID)
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

            DialogResult res = MessageBox.Show("Are Youse You Want to Submit Your Answers?","Submitting",MessageBoxButtons.YesNo);
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
                    
                    exam.questions[i].studentChoiceID = checkedID;
                    i++;
                }
                MessageBox.Show("submitted!");
                MessageBox.Show($"{exam.questions[0].studentChoiceDesc},{exam.questions[1].studentChoiceDesc},{exam.questions[2].studentChoiceDesc},{exam.questions[3].studentChoiceDesc},{exam.questions[4].studentChoiceDesc},{exam.questions[5].studentChoiceDesc},{exam.questions[6].studentChoiceDesc},{exam.questions[7].studentChoiceDesc},{exam.questions[8].studentChoiceDesc},{exam.questions[9].studentChoiceDesc}");
                MainApp.examForm.Close();
            }
        }

        
        private void examF_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainApp.studentForm.Show();
        }

    }
}


