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
    
    public partial class tblTransportDriver
    {        [Key]
        public int DriverId { get; set; }
        public string VehicleNo { get; set; }
        public string DriverName { get; set; }
        public string PresentAddress { get; set; }
        public string PermanentAddress { get; set; }
        public Nullable<System.DateTime> DriverBirthDate { get; set; }
        public string ContactNumberOther { get; set; }
        public string MobileNo { get; set; }
        public string LicenseNumber { get; set; }
        public string AcadamicYear { get; set; }
    }
}
