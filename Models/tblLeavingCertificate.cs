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
    
    public partial class tblLeavingCertificate
    {        [Key]
        public int LeavingCertificateID { get; set; }
        public string SchoolName { get; set; }
        public string SchoolAddress { get; set; }
        public string StudentName { get; set; }
        public string StudentID { get; set; }
        public string Gender { get; set; }
        public string StudentRollNumber { get; set; }
        public string Nationality { get; set; }
        public Nullable<System.DateTime> BirthYear { get; set; }
        public string AdmittedClass { get; set; }
        public string HighestClass { get; set; }
        public string Remarks { get; set; }
        public Nullable<System.DateTime> LeavingCertificateDate { get; set; }
        public Nullable<System.DateTime> LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public string AcadamicYear { get; set; }
    }
}
