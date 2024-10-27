using System.ComponentModel.DataAnnotations;
namespace SMS_Core.Models
{
    using System;
    using System.Collections.Generic;

    public partial class tblInstitute
    {
        [Key]
        public int? InstituteId { get; set; }
        public string? InstituteName { get; set; }
        public string? InstituteAddress { get; set; }
        public string? InstituteEmail { get; set; }
        public string? InstitutePhone { get; set; }
        public string? InstituteMobile { get; set; }
        public string? InstituteFax { get; set; }
        public string? InstituteAdminContactPerson { get; set; }
        public string? InstituteCity { get; set; }
        public string? InstituteState { get; set; }
        public string? InstituteCountry { get; set; }
        public string? InstituteCurrency { get; set; }
        public string? InstituteMedium { get; set; }
        public string? InstituteImagePath { get; set; }
        public string? InstituteType { get; set; }
        public string? CurrentUser { get; set; }
        public string? AcadamicYear { get; set; }
    }
}
