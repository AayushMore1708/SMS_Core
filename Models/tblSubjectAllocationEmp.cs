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
    
    public partial class tblSubjectAllocationEmp
    {
        public int SubjectAllocationEmpId { get; set; }
        public string SubjectAllocationDepartment { get; set; }
        public string SubjectAllocationEmp { get; set; }
        public string SubjectAllocationCourseName { get; set; }
        public Nullable<int> SubjectAllocationCourseId { get; set; }
        public string SubjectAllocationBatchName { get; set; }
        public Nullable<int> SubjectAllocationBatchId { get; set; }
        public string SubjectAllocated { get; set; }
        public Nullable<int> SubjectAllocationEmpCode { get; set; }
        public string AcadamicYear { get; set; }
    }
}
