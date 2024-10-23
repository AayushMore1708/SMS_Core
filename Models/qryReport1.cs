using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMS_Core.Models
{
    public class qryReport1
    {
        public Nullable<System.DateTime> FeeReceiptDate { get; set; }
        public Nullable<decimal> MiscFees { get; set; }
        public decimal MiscFeesMarathi { get; set; }
        public decimal TermFee1 { get; set; }
        public decimal TermFee2 { get; set; }

        public Nullable<decimal> Bounce { get; set; }
        public Nullable<decimal> Lumsum { get; set; }
        public Nullable<decimal> Balance2122 { get; set; }
        public Nullable<decimal> Balance2021 { get; set; }
        public Nullable<decimal> Balance1920 { get; set; }

        public decimal TutionFeesApr { get; set; }
        public decimal TutionFeesMay { get; set; }
        public decimal TutionFeesJun { get; set; }
        public decimal TutionFeesJul { get; set; }
        public decimal TutionFeesAug { get; set; }
        public decimal TutionFeesSep { get; set; }
        public decimal TutionFeesOct { get; set; }
        public decimal TutionFeesNov { get; set; }
        public decimal TutionFeesDec { get; set; }
        public decimal TutionFeesJan { get; set; }
        public decimal TutionFeesFeb { get; set; }
        public decimal TutionFeesMar { get; set; }
        public Nullable<decimal> MiscCalender { get; set; }
        public Nullable<decimal> MIscICard { get; set; }
        public Nullable<decimal> MiscExamFees { get; set; }
        public Nullable<decimal> MiscVVN { get; set; }
        public Nullable<decimal> MiscComputerFees { get; set; }
        public Nullable<decimal> MiscMiscFees { get; set; }
        public Nullable<decimal> MiscEscortCard { get; set; }
        public Nullable<decimal> FirstHalf { get; set; }
        public Nullable<decimal> SecondHalf { get; set; }
        public Nullable<decimal> FullYear { get; set; } 
        public string AcadamicCourceDescription { get; set; }
        public decimal AdmissionFee { get; set; }
        public string AdmissionType { get; set; }
        public string Medium { get; set; }
        public string FeeCourseName { get; set; }
    }
}