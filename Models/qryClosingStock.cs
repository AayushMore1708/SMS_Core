using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMS_Core.Models
{
    public class qryClosingStock
    {
               [Key]
        public string VendorName { get; set; }
       
        public string ItemCategory { get; set; }
        public string InventoryItem { get; set; }
        public int? InventoryQuantity { get; set; }
        public int? IssueQty { get; set; }
        public int? ClosingStock { get; set; }
    }
}