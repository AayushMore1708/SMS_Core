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
    
    public partial class qryFeePaymentNew
    {
        public int FeePaymentId { get; set; }
        public string FeeModeofPay { get; set; }
        public string FeeRemark { get; set; }
        public Nullable<int> FeeReceiptNo { get; set; }
        public string FeeCourseName { get; set; }
        public string FeeBatchName { get; set; }
        public string FeeStudentName { get; set; }
        public Nullable<int> FeeStudentID { get; set; }
        public Nullable<decimal> FeeTotalAmount { get; set; }
        public Nullable<System.DateTime> FeeReceiptDate { get; set; }
        public string AcadamicYear { get; set; }
        public string FeeType { get; set; }
        public Nullable<decimal> FeeActualAmount { get; set; }
        public Nullable<decimal> FeeAmountPaid { get; set; }
        public Nullable<decimal> FeeFine { get; set; }
        public Nullable<decimal> FeeDiscount { get; set; }
        public string Months { get; set; }
        public string Years { get; set; }
        public string FeeStatus { get; set; }
        public string FeeCategoryName { get; set; }
        public string FeeSubCategoryName { get; set; }
        public string OnlineRefId { get; set; }
        public string OnlineStatus { get; set; }
    }
}
