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
    
    public partial class tblEmployeeAttendance
    {
        public int AttendanceEmployeeID { get; set; }
        public string Department { get; set; }
        public Nullable<System.DateTime> AttendanceDate { get; set; }
        public string EmployeeID { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public string TimeIn { get; set; }
        public string TimeOut { get; set; }
        public string AttendanceStatus { get; set; }
        public string AttendanceRemark { get; set; }
        public string EmployeeUserName { get; set; }
        public string EmployeePhoto { get; set; }
        public string AcadamicYear { get; set; }
        public Nullable<System.DateTime> LastmodifiedDate { get; set; }
        public string LastmodifiedBy { get; set; }
    }
}
