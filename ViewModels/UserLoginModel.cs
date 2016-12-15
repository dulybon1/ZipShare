using System.ComponentModel.DataAnnotations;

namespace ZipShare.ViewModels
{
    public class UserLoginModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password {get; set;}
    }
}