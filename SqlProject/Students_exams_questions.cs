//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SqlProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Students_exams_questions
    {
        public int exam_ID { get; set; }
        public int qustion_ID { get; set; }
        public string student_answer { get; set; }
        public int student_ID { get; set; }
    
        public virtual exam exam { get; set; }
        public virtual question question { get; set; }
        public virtual student student { get; set; }
    }
}
