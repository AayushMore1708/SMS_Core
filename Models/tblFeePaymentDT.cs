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
    
    public partial class tblFeePaymentDT
    {
        [Key]
        public int FeePaymentIDDT { get; set; }
        public Nullable<int> FeePaymentID { get; set; }
        public string FeeCategoryName { get; set; }
        public string FeeSubCategoryName { get; set; }
        public string FeeType { get; set; }
        public Nullable<decimal> FeeActualAmount { get; set; }
        public Nullable<decimal> FeeAmountPaid { get; set; }
        public Nullable<decimal> FeeFine { get; set; }
        public Nullable<decimal> FeeDiscount { get; set; }
        public string AcadamicYear { get; set; }
        public string Months { get; set; }
        public string Years { get; set; }
        public string FeeStatus { get; set; }
        public Nullable<int> PaymentMonths { get; set; }
        public Nullable<decimal> DiscountPerc { get; set; }
        public string FeePaymentMethod { get; set; }
        public Nullable<decimal> PaymentMonthsAmt { get; set; }
        public Nullable<decimal> ExtraBalance { get; set; }
        public Nullable<int> FeeID { get; set; }
        public Nullable<System.DateTime> LastUpdatedDateTime { get; set; }
        public string LastUpdatedBy { get; set; }
    
        public virtual tblFeePayment tblFeePayment { get; set; }
    }
}
