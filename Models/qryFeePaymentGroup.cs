using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMS_Core.Models
{
    public class qryFeePaymentGroup
    {
        public string FeeCategoryName { get; set; }
        public decimal? FeeAmountPaid { get; set; }

        public DateTime FeeReceiptDate { get; set; }

        public string AcadamicCourceDescription { get; set; }
    }
}