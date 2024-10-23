using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SMS_Core.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        //[EmailAddress]
        public string UsernName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        public string Id { get; set; }
        // [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
        public string UserType { get; set; }
        public Nullable<bool> PhoneNumberConfirmed { get; set; }
        public Nullable<bool> TwoFactorEnabled { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentName { get; set; }
        public string UserDepartment { get; set; }
        public string StudentSARALID { get; set; }
        public string StudentMiddleName { get; set; }
        public string StudentLastName { get; set; }
        public Nullable<System.DateTime> StudentDOB { get; set; }
        public Nullable<System.DateTime> DateofAdmissionImport { get; set; }
        public string StudentBirthPlace { get; set; }
        public string StandardDivisionImport { get; set; }
        public string StudentGender { get; set; }
        public string StudentBloodGroup { get; set; }
        public string StudentNationality { get; set; }
        public string StudentMotherTongue { get; set; }
        public string StudentCategory { get; set; }
        public string StudentReligion { get; set; }
        public string StudentCaste { get; set; }
        public string StudentSubCaste { get; set; }
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
        public string StudentParentPhone { get; set; }
        public string StudentParentAddress { get; set; }
        public string StudentParentLocality { get; set; }
        public string StudentParentPincode { get; set; }
        public string StudentParentCity { get; set; }
        public string StudentParentState { get; set; }
        public string StudentParentCountry { get; set; }
        public string StudentParentRelation { get; set; }
        public string StudentParentEducation { get; set; }
        public string StudentParentOccupation { get; set; }
        public string StudentParentIncome { get; set; }
        public string StudentParentFamilyIncome { get; set; }
        public string StudentFatherName { get; set; }
        public string StudentFatherMobile { get; set; }
        public string StudentFatherJob { get; set; }
        public string StudentMotherName { get; set; }
        public string StudentMotherMobile { get; set; }
        public string StudentMotherJob { get; set; }
        public string StudentAadharNumber { get; set; }
        public string StudentPreviousSchoolName { get; set; }
        public string StudentPreviousSchoolDetails { get; set; }
        public string StudentPreviousQualification { get; set; }
        public string StudentTaluka { get; set; }
        public string StudentDistrict { get; set; }
        public string DateOfBirthinwords { get; set; }
        public string SchoolUDISENo { get; set; }
        public string UIDAdharCardNo { get; set; }
        public string GeneralRegisterNO { get; set; }
        public int Feeid { get; set; }
        public string StudentLCNo { get; set; }
        public string StudentProgress { get; set; }
        public string StudentConduct { get; set; }
        public Nullable<System.DateTime> DateOfLeavingSchool { get; set; }
        public Nullable<System.DateTime> StudentAdmissionDates { get; set; }
        public string StandardInWhichStudyingFigure { get; set; }
        public string StandardInWhichStudyingWord { get; set; }
        public string StandardInWhichStudyingSinceWhenFigure { get; set; }
        public string StandardInWhichStudyingSinceWhenWord { get; set; }
        public string StudentStandard { get; set; }
        public string ReasonForLeavingSchool { get; set; }
        public string Remarks { get; set; }
        public string Photo { get; set; }
        public string UserName { get; set; }
        public string GRType { get; set; }

        public string StandardFromLeft { get; set; }
        public string DivisionFromLeft { get; set; }
        public string OtherRemarks { get; set; }
        public string CorrectEntrySign { get; set; }
        public Nullable<System.DateTime> ReceivingDateLC { get; set; }
        public Nullable<System.DateTime> LastModifiedDateTime { get; set; }
        public string LastModifiedBy { get; set; }
        public string AdmissionFormPhoto { get; set; }
        public string BirthLeavingCertificatePhoto { get; set; }
        public string CasteCertificatePhoto { get; set; }
        public string AdharCardPhoto { get; set; }
        public string StudentSteam { get; set; }
        public string FirstGuardianEmail { get; set; }
        public string SecondGuardianEmail { get; set; }

    }


    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
