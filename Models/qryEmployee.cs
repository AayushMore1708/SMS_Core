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
    
    public partial class qryEmployee
    {        [Key]
        public string UserName { get; set; }
        public int Id { get; set; }
        public Nullable<int> EmpCode { get; set; }
        public string UserID { get; set; }
        public Nullable<System.DateTime> JoiningDate { get; set; }
        public Nullable<System.DateTime> LeavingDate { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }
        public string Qualification { get; set; }
        public string ExperianceDetails { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string Gender { get; set; }
        public string AadharNumber { get; set; }
        public string PANNumber { get; set; }
        public string PFNumber { get; set; }
        public string ESI { get; set; }
        public string Address { get; set; }
        public string Locality { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Pincode { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string EmailN { get; set; }
        public string EmployeePhoto { get; set; }
        public string UserType { get; set; }
        public string EName { get; set; }
    }
}
