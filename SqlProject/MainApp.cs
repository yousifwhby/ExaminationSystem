using SqlProject.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlProject
{
    public static class MainApp
    {
       public static Studentf studentForm;
       public static Instructorf InstructorForm;
       public static Login loginForm;
        public static Examf examForm;
        public static SQLProjectEntities3 entity;
        public static int UserID;
        public static string UserName;
        public static student std_us;
        public static Admin adminForm;


        static MainApp()
        {
            loginForm = new Login();
            entity = new SQLProjectEntities3();
        }


    }
}
