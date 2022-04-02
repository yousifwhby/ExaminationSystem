using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlProject
{
    public partial class Instructorf : Form
    {
        //SQLProjectEntities4 ent;
        int instID;
        string instName;
        public Instructorf()
        {
            InitializeComponent();
            //ent = new SQLProjectEntities4();
            instID = MainApp.UserID;
            instName = MainApp.UserName;
        }

        #region Rerender fns
        public void RerenderCourses(ComboBox comboBox)
        {
            var items = (from C in MainApp.entity.instructors where C.instructor_ID == instID select C.courses).FirstOrDefault();
            comboBox.Items.Clear();
            foreach (var item in items)
            {
                comboBox.Items.Add(item.course_name);
            }
        }
        public int RerenderExams(ComboBox comboBox, string courseName)
        {
            int res;
            var items = (from C in MainApp.entity.exams select C).Where(a=>a.cours.course_name == courseName).ToList();
            if (items == null)
            {
                res = 0;
            }
            else
            {
                res = 1;
            }
            comboBox.Items.Clear();
            foreach (var item in items)
            {
                comboBox.Items.Add(item.exam_ID);
            }
            return res;
        }
        public void RerenderDepartments(ComboBox comboBox)
        {
            var items = from C in MainApp.entity.departments select C;
            comboBox.Items.Clear();
            foreach (var item in items)
            {
                comboBox.Items.Add(item.department_name);
            }
        }
        public void RerenderStudents(CheckedListBox checkBox, string DepName)
        {
            var items = (from C in MainApp.entity.students select C).Where(a => a.department.department_name == DepName && a.student_ID != 0).ToList(); 
            checkBox.Items.Clear();
            foreach (var item in items)
            {
                checkBox.Items.Add(item.student_Fname +" "+ item.student_Lname );
            }
            checkBox.Items.Add("Select all students");
        }

        public void RerenderStudents(ComboBox comboBox)
        {
            var items = (from C in MainApp.entity.students select C).ToList();
            comboBox.Items.Clear();
            foreach (var item in items)
            {
                comboBox.Items.Add(item.student_ID);
            }
        }

        //public void RerenderExamQs(ListBox listBox, int ExamID)
        //{
        //    var items = (from C in MainApp.entity.Students_exams_questions where C.exam_ID == ExamID select C.question).Distinct();
        //    listBox.Items.Clear();
        //    foreach (var item in items)
        //    {
        //        listBox.Items.Add("-"+item.qusetion_desc +"   -"+ String.Join("  -", item.choices.Select(a=> a.choice_description).Distinct()));
        //    }
        //}
        public void RerenderExamQs(DataGridView dgv, int ExamID)
        {
            dgv.Rows.Clear();
            var items = (from C in MainApp.entity.Students_exams_questions where C.exam_ID == ExamID select C.question).Distinct();
            int i = 0;
            foreach (var item in items)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = item.qusetion_desc;
                dgv.Rows[i].Cells[1].Value = item.choices.ElementAt(0).choice_description;
                dgv.Rows[i].Cells[2].Value = item.choices.ElementAt(1).choice_description;
                if (item.choices.Count == 3)
                {
                    dgv.Rows[i].Cells[3].Value = item.choices.ElementAt(2).choice_description;
                }
                i += 1;
            }
        }

        #endregion





        private void Instructorf_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Instructorf_Load(object sender, EventArgs e)
        {
            // courses tab
            label1.Text = "Hello " + instName.ToUpper() + " ," ;
            label2.Text = "your Courses : ";
            dataGridView1.DataSource = MainApp.entity.r3_instructor_courses(instID);
            dataGridView1.Columns.RemoveAt(0);
            //------------------------------------------------------------------------
            //exams tab
            RerenderCourses(comboBoxSelectCourseInGenerateExamTab);
            RerenderCourses(comboBoxCoursesInAssignExamTab);
            //------------------------------------------------------------------------
            //students tab
            RerenderStudents(comboBoxStudentsID);
            RerenderDepartments(comboBoxDepINStudentsTab);
            
        }

        private void buttonGenerateExam_Click(object sender, EventArgs e)
        {
            if(comboBoxSelectCourseInGenerateExamTab.Text != string.Empty)
            {
                if(textBoxTFQS.Text != string.Empty && int.TryParse(textBoxTFQS.Text, out int res) == true)
                {
                    if(textBoxMCQQS.Text != string.Empty && int.TryParse(textBoxMCQQS.Text, out int res2) == true)
                    {
                        if (res + res2 == 10)
                        {
                            if(textBoxExamDuratn.Text != string.Empty && int.TryParse(textBoxExamDuratn.Text, out int res3) == true)
                            {
                                MainApp.entity.generateExam(comboBoxSelectCourseInGenerateExamTab.Text, res, res2, res3);
                                comboBoxSelectCourseInGenerateExamTab.Text = textBoxExamDuratn.Text = textBoxMCQQS.Text = textBoxTFQS.Text = string.Empty;
                                MessageBox.Show("Exam generated successfully");
                            }
                            else
                            {
                                MessageBox.Show("you must enter a valid time interval");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Exam must contain 10 Questions");
                        }
                    }
                    else
                    {
                        MessageBox.Show("you must enter a valid number of MCQ Questions");
                    }
                }
                else
                {
                    MessageBox.Show("you must enter a valid number of True or False Questions");
                }
            }
            else
            {
                MessageBox.Show("you must select course in order to generate Exam");
            }
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCoursesInAssignExamTab.Items.Clear();
            //comboBoxDepartmentInAssignExamTab.Items.Clear();
            comboBoxExamsInAssignExamTab.Items.Clear();
            comboBoxSelectCourseInGenerateExamTab.Items.Clear();
            listBox1.Items.Clear();
            checkedListBox1.Items.Clear();
            //exams tab
            RerenderCourses(comboBoxSelectCourseInGenerateExamTab);
            RerenderCourses(comboBoxCoursesInAssignExamTab);
            //RerenderDepartments(comboBoxDepartmentInAssignExamTab);

        }

        private void comboBoxCoursesInAssignExamTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            int exams = RerenderExams(comboBoxExamsInAssignExamTab, comboBoxCoursesInAssignExamTab.Text);
            if(exams == 0)
            {
                MessageBox.Show($"there is no exams for {comboBoxCoursesInAssignExamTab.Text}");
            }
            else
            {
                var items = (from C in MainApp.entity.courses where C.course_name == comboBoxCoursesInAssignExamTab.Text select C.students.Select(a=>a.department.department_name).Distinct()).FirstOrDefault();
                comboBoxDepartmentInAssignExamTab.Items.Clear();
                foreach (var item in items)
                {
                    comboBoxDepartmentInAssignExamTab.Items.Add(item);
                }
            }
        }

        private void comboBoxExamsInAssignExamTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            //RerenderExamQs(listBox1,int.Parse(comboBoxExamsInAssignExamTab.Text));
            RerenderExamQs(dataGridViewExamQs, int.Parse(comboBoxExamsInAssignExamTab.Text));
        }

        private void comboBoxDepartmentInAssignExamTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            RerenderStudents(checkedListBox1,comboBoxDepartmentInAssignExamTab.Text);
        }

        private void buttonAssignExam_Click(object sender, EventArgs e)
        {
            if (comboBoxExamsInAssignExamTab.Text != string.Empty)
            {
                var checkedItems = checkedListBox1.CheckedItems;
                if (checkedItems.Count > 0)
                {
                    int examID = int.Parse(comboBoxExamsInAssignExamTab.Text);
                    if (checkedItems[checkedItems.Count-1].ToString() == "Select all students")
                    {
                        foreach(var std in checkedListBox1.Items)
                        {
                            var stdID = (from S in MainApp.entity.students where (S.student_Fname + " " + S.student_Lname) == std.ToString() select S.student_ID).FirstOrDefault();
                            if (stdID != 0)
                            {
                                MainApp.entity.AssignExamTOStudent(examID,stdID);
                            }
                        }
                    }
                    else
                    {
                        foreach (var std in checkedItems)
                        {
                            var stdID = (from S in MainApp.entity.students where (S.student_Fname + " " + S.student_Lname) == std.ToString() select S.student_ID).FirstOrDefault();
                            if (stdID != 0)
                            {
                                MainApp.entity.AssignExamTOStudent(examID, stdID);
                            }
                        }
                    }
                    MessageBox.Show("Exam assigned successfully");
                }
                else
                {
                    MessageBox.Show("you have not select any student");
                }
            }
            else
            {
                MessageBox.Show("Select the Exam");
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxStdFname.Text != string.Empty && textBoxStdLname.Text != string.Empty && textBoxStdUSerName.Text != string.Empty && textBoxStdPass1.Text !=string.Empty && textBoxStdPass2.Text !=string.Empty && comboBoxDepINStudentsTab.Text != string.Empty)
            {
                if(textBoxStdPass1.Text == textBoxStdPass2.Text)
                {
                    student std = new student();
                    std.student_Fname = textBoxStdFname.Text;
                    std.student_Lname = textBoxStdLname.Text;
                    std.student_UserName = textBoxStdUSerName.Text;
                    std.student_Password = textBoxStdPass2.Text;
                    int depID = (from D in MainApp.entity.departments where D.department_name == comboBoxDepINStudentsTab.Text select D.department_ID).First();
                    std.department_ID = depID;
                    MainApp.entity.students.Add(std);
                    MainApp.entity.SaveChanges();
                    textBoxStdFname.Text = textBoxStdLname.Text = textBoxStdUSerName.Text = textBoxStdPass1.Text = textBoxStdPass2.Text = comboBoxDepINStudentsTab.Text = string.Empty;
                    RerenderStudents(comboBoxStudentsID);
                    MessageBox.Show("Student Added");
                }
                else
                {
                    MessageBox.Show("conflicted password");
                    textBoxStdPass1.Text = textBoxStdPass2.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("All fields of student are required");
            }
        }

        private void comboBoxStudentsID_SelectedIndexChanged(object sender, EventArgs e)
        {
            var std = MainApp.entity.students.Find(int.Parse(comboBoxStudentsID.Text));
            textBoxStdFname.Text = std.student_Fname;
            textBoxStdLname.Text = std.student_Lname;
            textBoxStdUSerName.Text = std.student_UserName;
            textBoxStdPass1.Text = std.student_Password;
            comboBoxDepINStudentsTab.Text = std.department.department_name;
            RerenderDepartments(comboBoxDepINStudentsTab);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (comboBoxStudentsID.Text != string.Empty)
            {
                if (textBoxStdFname.Text != string.Empty && textBoxStdLname.Text != string.Empty && textBoxStdUSerName.Text != string.Empty && textBoxStdPass1.Text != string.Empty && textBoxStdPass2.Text != string.Empty && comboBoxDepINStudentsTab.Text != string.Empty)
                {
                    if (textBoxStdPass1.Text == textBoxStdPass2.Text)
                    {
                        var std = MainApp.entity.students.Find(int.Parse(comboBoxStudentsID.Text));
                        std.student_Fname = textBoxStdFname.Text;
                        std.student_Lname = textBoxStdLname.Text;
                        std.student_UserName = textBoxStdUSerName.Text;
                        std.student_Password = textBoxStdPass2.Text;
                        int depID = (from D in MainApp.entity.departments where D.department_name == comboBoxDepINStudentsTab.Text select D.department_ID).First();
                        std.department_ID = depID;
                        MainApp.entity.SaveChanges();
                        textBoxStdFname.Text = textBoxStdLname.Text = textBoxStdUSerName.Text = textBoxStdPass1.Text = textBoxStdPass2.Text = comboBoxDepINStudentsTab.Text = string.Empty;
                        MessageBox.Show("Student data updated");

                    }
                    else
                    {
                        MessageBox.Show("conflicted password");
                        textBoxStdPass1.Text = textBoxStdPass2.Text = string.Empty;
                    }
                }
                else
                {
                    MessageBox.Show("All fields of student are required");
                }
            }
            else
            {
                MessageBox.Show("Select student ID");
            }
        }
    }
}
