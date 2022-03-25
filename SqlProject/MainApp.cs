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
        public static SQLProjectEntities2 entity;
        public static int UserID;
        

        static MainApp()
        {
            loginForm = new Login();
            entity = new SQLProjectEntities2();
        }


    }
}
