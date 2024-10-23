using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMS_Core.Models
{
    public class qryReport1Month25
    {
        
        public int Year { get; set; }
        public int Month { get; set; }
        public string MonthName { get; set; }
        public decimal TermFee { get; set; }
        public decimal MiscFeesMarathi { get; set; } 
        public decimal TutionFees { get; set; }
        public Nullable<decimal> MIscICard { get; set; }         
        public string AcadamicCourceDescription { get; set; }
        public decimal AdmissionFee { get; set; } 
        public decimal? MiscCalender { get; set; }
        public decimal? MiscExamFees { get; set; }
        public decimal? MiscVVN { get; set; }
        public decimal? MiscComputerFees { get; set; }
        public decimal? MiscMiscFees { get; set; }

        public decimal? MiscFees { get; set; }

    }
}