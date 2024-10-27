using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SMS_Core.Models
{
    public class ApplicationUser : IdentityUser
    {        [Key]
        public string UserType { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentMiddleName { get; set; }
        public string StudentLastName { get; set; }
        public DateTime? StudentDOB { get; set; }
        public string StudentBirthPlace { get; set; }
        public string StudentGender { get; set; }
        public string StudentBloodGroup { get; set; }
        public string StudentNationality { get; set; }
        public string StudentMotherTongue { get; set; }
        public string StudentCategory { get; set; }
        public string StudentReligion { get; set; }
        public string StudentCaste { get; set; }
        public string StudentAddress { get; set; }
        public string StudentLocality { get; set; }
        public string StudentPincode { get; set; }
        public string StudentCity { get; set; }
        public string StudentState { get; set; }
        public string StudentCountry { get; set; }
        public string StudentPhone { get; set; }
        public string StudentParentMobile { get; set; }
        public string StudentParentEmail { get; set; }
        public string StudentParentName { get; set; }
        public string StudentFatherName { get; set; }
        public string StudentMotherName { get; set; }
        public string StudentAadharNumber { get; set; }
        public DateTime? DateOfLeavingSchool { get; set; }
        public DateTime? StudentAdmissionDates { get; set; }
        public string ReasonForLeavingSchool { get; set; }
        public string Remarks { get; set; }
        public DateTime? LastModifiedDateTime { get; set; }
        public string LastModifiedBy { get; set; }

        public async Task<ClaimsPrincipal> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Create a claims identity for the user
            var userIdentity = await manager.CreateAsync(this);

            // Add any custom claims if needed
            var claimsIdentity = new ClaimsIdentity("Identity.Application");

            // Optionally, add more custom claims, such as UserType, etc.
            claimsIdentity.AddClaim(new Claim(ClaimTypes.Name, this.UserName));
            claimsIdentity.AddClaim(new Claim("UserType", this.UserType ?? ""));

            return new ClaimsPrincipal(claimsIdentity);
        }

    }
}
