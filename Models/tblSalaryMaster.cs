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
    
    public partial class tblSalaryMaster
    {
        public int SalarymstID { get; set; }
        public string EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Designation { get; set; }
        public Nullable<double> WorkDays { get; set; }
        public Nullable<decimal> CTC { get; set; }
        public string CompanyName { get; set; }
        public Nullable<decimal> BasicSalary { get; set; }
        public Nullable<decimal> DA { get; set; }
        public Nullable<decimal> HRA { get; set; }
        public Nullable<decimal> Conveyance { get; set; }
        public Nullable<decimal> MedicalExpenses { get; set; }
        public Nullable<decimal> Bonus { get; set; }
        public Nullable<decimal> TravelAllowance { get; set; }
        public Nullable<decimal> PF { get; set; }
        public Nullable<decimal> ProfessionTax { get; set; }
        public Nullable<decimal> TDS { get; set; }
        public string LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModifiedDate { get; set; }
        public Nullable<double> TotalHoliday { get; set; }
        public string AcadamicYear { get; set; }
    }
}
