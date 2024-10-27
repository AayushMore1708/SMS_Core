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

    public partial class tblFeePaymentAY25
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblFeePaymentAY25()
        {
            this.tblFeePaymentDTAY25 = new HashSet<tblFeePaymentDTAY25>();
        }
        [Key]
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
        public Nullable<decimal> FeeActualAmount { get; set; }
        public string OnlineRefId { get; set; }
        public Nullable<decimal> OnlineAmt { get; set; }
        public string OnlineStatus { get; set; }
        public Nullable<decimal> ExtraBalance { get; set; }
        public Nullable<decimal> BalanceFee2021 { get; set; }
        public Nullable<decimal> BalanceFee2122 { get; set; }
        public Nullable<decimal> BalanceFee1920 { get; set; }
        public Nullable<decimal> TotalAmoutPaying { get; set; }
        public Nullable<decimal> TotalBalance { get; set; }
        public Nullable<decimal> FeeFine { get; set; }
        public string FeeFineDetails { get; set; }
        public string FeeCancel { get; set; }
        public Nullable<System.DateTime> LastUpdatedDateTime { get; set; }
        public string LastUpdatedBy { get; set; }
        public string BankRefId { get; set; }
        public Nullable<int> FeeDescID { get; set; }
        public string ChequeNo { get; set; }
        public string BankName { get; set; }
        public Nullable<System.DateTime> ValueDate { get; set; }
        public Nullable<System.DateTime> CancelDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblFeePaymentDTAY25> tblFeePaymentDTAY25 { get; set; }
    }
}
