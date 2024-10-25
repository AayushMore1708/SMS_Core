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
    
    public partial class tblStockInventoryItem
    {
        public int InventoryItemId { get; set; }
        public Nullable<int> VendorID { get; set; }
        public string VendorName { get; set; }
        public string ItemCategory { get; set; }
        public string InventoryItem { get; set; }
        public Nullable<int> InventoryQuantity { get; set; }
        public Nullable<int> Reorderlevel { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> MRP { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<int> PO { get; set; }
        public Nullable<int> PurchaseReceiptId { get; set; }
        public Nullable<decimal> POItemNetAmount { get; set; }
        public Nullable<decimal> POItemCGST { get; set; }
        public Nullable<decimal> POItemSGST { get; set; }
        public Nullable<decimal> POItemIGST { get; set; }
        public Nullable<decimal> POItemTotalAmount { get; set; }
        public Nullable<int> IssueQty { get; set; }
        public string LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModifiedDate { get; set; }
        public string AcadamicYear { get; set; }
    
        public virtual tblPurchaseReceipt tblPurchaseReceipt { get; set; }
    }
}