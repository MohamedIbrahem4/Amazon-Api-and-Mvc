using System.ComponentModel.DataAnnotations;

namespace AdminSiteUseMVC.ViewModel.Admin
{
    public class ForgotPasswordModel
    {
        [Required, EmailAddress, Display(Name ="Registered Email Address")]
        public string Email { get; set; }
        public bool EmailSent { get; set; }
    }
}
