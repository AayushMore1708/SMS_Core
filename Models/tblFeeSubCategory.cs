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
    
    public partial class tblFeeSubCategory
    {
        public int FeeSubCategoryId { get; set; }
        public string FeeCategoryName { get; set; }
        public string FeeSubCategoryName { get; set; }
        public Nullable<decimal> FeeSubCategoryAmount { get; set; }
        public string FeeType { get; set; }
        public string AcadamicYear { get; set; }
        public Nullable<System.DateTime> FullInstallmentDate { get; set; }
        public Nullable<decimal> FullInstallmentPerc { get; set; }
        public Nullable<System.DateTime> FirstInstallmentDate { get; set; }
        public Nullable<decimal> FirstInstallmentPerc { get; set; }
        public Nullable<System.DateTime> SecondInstallmentDate { get; set; }
        public Nullable<decimal> SecondInstallmentPerc { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> AmontDiscount { get; set; }
        public Nullable<System.DateTime> DateUpto { get; set; }
        public Nullable<decimal> DiscountAmount { get; set; }
        public string Installment { get; set; }
        public Nullable<decimal> FullInstallmentDiscount { get; set; }
        public Nullable<decimal> FullInstallmentDiscountAmt { get; set; }
        public Nullable<decimal> FirstInstallmentDiscount { get; set; }
        public Nullable<decimal> FirstInstallmentDiscountAmt { get; set; }
        public Nullable<decimal> SecondInstallmentDiscount { get; set; }
        public Nullable<decimal> SecondinstallmentDiscountAmt { get; set; }
        public Nullable<System.DateTime> PaymentStartDate { get; set; }
        public Nullable<System.DateTime> PaymentEndDate { get; set; }
        public Nullable<decimal> TusionFees { get; set; }
        public Nullable<decimal> TermFee1 { get; set; }
        public Nullable<decimal> TermFee2 { get; set; }
        public Nullable<decimal> MiscFee { get; set; }
        public Nullable<decimal> TotalFees { get; set; }
        public Nullable<decimal> DiscountNew { get; set; }
        public Nullable<decimal> MiscCalender { get; set; }
        public Nullable<decimal> MIscICard { get; set; }
        public Nullable<decimal> MiscExamFees { get; set; }
        public Nullable<decimal> MiscVVN { get; set; }
        public Nullable<decimal> MiscComputerFees { get; set; }
        public Nullable<decimal> MiscMiscFees { get; set; }
        public string FeeMedium { get; set; }
        public string AdmissionType { get; set; }
        public Nullable<decimal> MiscEscortCard { get; set; }
    }
}