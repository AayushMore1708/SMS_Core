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
    
    public partial class tblTransportFeeCollection
    {        [Key]
        public int TransportFeeId { get; set; }
        public string TransportUserTyp { get; set; }
        public string TransportCouseName { get; set; }
        public string TransportBatchName { get; set; }
        public string TransportStudentName { get; set; }
        public Nullable<int> TransportStudentID { get; set; }
        public string TransportEmpDepartment { get; set; }
        public string TransportEmpName { get; set; }
        public Nullable<int> TransportEmpID { get; set; }
        public string TransportRouteDestination { get; set; }
        public string TransportFeeType { get; set; }
        public Nullable<decimal> TransportFeeTotalAmount { get; set; }
        public Nullable<decimal> TransportFeePaidAmount { get; set; }
        public Nullable<decimal> TransportFeeFine { get; set; }
        public Nullable<decimal> TransportFeeDiscount { get; set; }
        public string TransportModePay { get; set; }
        public string TransportReceiptNo { get; set; }
        public string AcadamicYear { get; set; }
    }
}
