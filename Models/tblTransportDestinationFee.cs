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
    
    public partial class tblTransportDestinationFee
    {
        public int DestinationId { get; set; }
        public string RouteCode { get; set; }
        public string PickupAndDrop { get; set; }
        public Nullable<System.TimeSpan> PickupTime { get; set; }
        public Nullable<System.TimeSpan> DropTime { get; set; }
        public Nullable<decimal> DestinationAmount { get; set; }
        public string DestinationFeeType { get; set; }
        public string AcadamicYear { get; set; }
    }
}
