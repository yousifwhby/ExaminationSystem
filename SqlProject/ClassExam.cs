using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlProject
{
    class ClassExam
    {
        public ClassQuestion[] questions;
        public ClassExam()
        {
            questions = new ClassQuestion[10];
        }
    }
    public class ClassQuestion
    {
        public int qID;
        public string qDesc;
        public ClassChoice[] choices;
        public int studentChoiceID;
        public string studentChoiceDesc;
        public ClassQuestion()
        {
            choices = new ClassChoice[3];
            qID = 0;
            qDesc = null;
            studentChoiceID = 0;
            studentChoiceDesc = "";
        }
    }
    public class ClassChoice
    {
        public int cID;
        public string cDesc;
        public ClassChoice()
        {
            cID = 0;
            cDesc = "";
        }
    }
}
