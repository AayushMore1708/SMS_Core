//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SMS_Core.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblClassTeacherAllocation
    {
                [Key]
        public int ClassTeacherId { get; set; }
        public string CourseName { get; set; }
        public string CourseBatch { get; set; }
        public Nullable<int> CourseID { get; set; }
        public Nullable<int> BatchID { get; set; }
        public Nullable<int> TeacherEmpID { get; set; }
        public string TeacherEmpUserName { get; set; }
        public string AcadamicYear { get; set; }
    }
}
