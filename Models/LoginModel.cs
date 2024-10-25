using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace SMS_Core.Models
{
    public class LoginModel
    {
        [Required]
        public string UsernName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string SelectedAcademicYear { get; set; }

        public List<SelectListItem> AcademicYears { get; set; }

        public bool RememberMe { get; set; }
    }
}
