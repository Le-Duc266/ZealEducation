//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Grade
    {
        public int GradeID { get; set; }
        public string StudentID { get; set; }
        public string SubjectID { get; set; }
        public Nullable<int> ExamNumber { get; set; }
        public decimal GradeOfNumber { get; set; }
        public string note { get; set; }
        public int GradeTypeID { get; set; }
        public Nullable<bool> Status { get; set; }
    
        public virtual GradeType GradeType { get; set; }
        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
