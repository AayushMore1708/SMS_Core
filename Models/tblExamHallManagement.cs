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
    
    public partial class tblExamHallManagement
    {        [Key]
        public int ExamHallManagementId { get; set; }
        public string ExamHallNo { get; set; }
        public string CourseName { get; set; }
        public string BatchName { get; set; }
        public string ExamName { get; set; }
        public string ExamTime { get; set; }
        public string AcadamicYear { get; set; }
    }
}
