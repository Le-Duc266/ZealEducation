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
    
    public partial class Subject
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Subject()
        {
            this.ClassSubjects = new HashSet<ClassSubject>();
            this.ExamSchedules = new HashSet<ExamSchedule>();
            this.FeesDetails = new HashSet<FeesDetail>();
            this.Grades = new HashSet<Grade>();
            this.MultiSubjectTeachers = new HashSet<MultiSubjectTeacher>();
            this.TimeTables = new HashSet<TimeTable>();
        }
    
        public string SubjectID { get; set; }
        public string SubjectName { get; set; }
        public string Abbreviation { get; set; }
        public Nullable<int> lesson { get; set; }
        public Nullable<double> price { get; set; }
        public Nullable<bool> Status { get; set; }
        public string FacultyID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClassSubject> ClassSubjects { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExamSchedule> ExamSchedules { get; set; }
        public virtual Faculty Faculty { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FeesDetail> FeesDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Grade> Grades { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MultiSubjectTeacher> MultiSubjectTeachers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TimeTable> TimeTables { get; set; }
    }
}
