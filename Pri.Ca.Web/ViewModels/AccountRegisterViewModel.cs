using System.ComponentModel.DataAnnotations;

namespace Pri.Ca.Web.ViewModels
{
    public class AccountRegisterViewModel : AccountLoginViewModel
    {
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        [DataType(DataType.Password)]
        [Required]
        [Compare("Password")]
        public string RepeatPassword { get; set; }
    }
}
