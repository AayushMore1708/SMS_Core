//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace SMS_Core.Models
{
    using System;
    using System.Collections.Generic;

    public partial class tblVisitor
    {
        [Key]
        public int VisitorID { get; set; }
        public string VisitorCategory { get; set; }
        public string VisitorName { get; set; }
        public string WhomToVisit { get; set; }
        public string VisitPurpose { get; set; }
        public string CourseName { get; set; }
        public string BatchName { get; set; }
        public string StudentName { get; set; }
        public string TeacherName { get; set; }
        public Nullable<System.DateTime> VisitDate { get; set; }
        public Nullable<System.TimeSpan> VisitTime { get; set; }
        public string VisitorTokenNo { get; set; }
        public string VisitorStatus { get; set; }
        public string VisitorDetails { get; set; }
        public string WhomToVisitCategory { get; set; }
        public string AcadamicYear { get; set; }
    }
}
