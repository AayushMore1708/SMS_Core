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
    using System.ComponentModel.DataAnnotations;
    public partial class StudentMarks
    {

        [Key]
        public int StudentMarksID { get; set; } // Corresponds to [StudentMarksID]
        public string AcadamicYear { get; set; } // Corresponds to [AcadamicYear]
        public string SchoolName { get; set; } // Corresponds to [SchoolName]
        public string Semester { get; set; } // Corresponds to [Semester]
        public int StudentID { get; set; } // Corresponds to [StudentID]
        public string GRNo { get; set; } // Corresponds to [GRNo]
    }
}
