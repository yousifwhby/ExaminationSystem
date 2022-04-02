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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void UserType_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
         if (username_TB.Text!= string.Empty && password_TB.Text!=string.Empty)
            {

            if (UserType!= null && UserType.SelectedItem.ToString() == "Student")
            {
                //username_TB.Text = UserType.SelectedItem.ToString();
                var Usname = MainApp.entity.students.Where(s => s.student_UserName == username_TB.Text).FirstOrDefault();
                if (Usname!=null && Usname.student_UserName == username_TB.Text && Usname.student_Password == password_TB.Text)
                {
                     MainApp.UserID = Usname.student_ID;
                        MainApp.UserName = Usname.student_Lname;
                        MainApp.std_us = Usname;
                        this.Hide();
                     MainApp.studentForm = new Studentf();
                     MainApp.studentForm.Show();
                }
                else
                {
                    MessageBox.Show("Wrong username or password");
                }

            }
           
            else if (UserType !=null && UserType.SelectedItem.ToString() == "Instructor")
            {
                //password_TB.Text = UserType.SelectedItem.ToString();
                
                var Usname = MainApp.entity.instructors.Where(s => s.instructor_UserName == username_TB.Text).FirstOrDefault();
               if("Admin" == username_TB.Text && "0000"== password_TB.Text)
                    {
                        MainApp.UserID = Usname.instructor_ID;
                        MainApp.UserName = Usname.instructor_name;


                        this.Hide();
                        MainApp.adminForm = new Forms.Admin();
                        MainApp.adminForm.Show();

                    }
                    
                    
                    else if (Usname != null &&Usname.instructor_UserName == username_TB.Text && Usname.instructor_Password == password_TB.Text)
                {
                    MainApp.UserID = Usname.instructor_ID;
                     MainApp.UserName = Usname.instructor_name;
                        

                    this.Hide();
                    MainApp.InstructorForm = new Instructorf();
                    MainApp.InstructorForm.Show();
                }
                else
                {
                    MessageBox.Show("Wrong username or password");
                }
            }
            else 
            {
                MessageBox.Show("Please Chose User Type");
            }
         }
        else
        {
            MessageBox.Show("Please Fill Username and password Fields");
        }

        }
    }
}
