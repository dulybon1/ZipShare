using System.ComponentModel.DataAnnotations;

namespace ZipShare.ViewModels
{
    public class UserRegisterModel
    {

        [Required]
        [StringLengthAttribute(30)]
        public string FirstName { get; set; }

        [Required]
        [StringLengthAttribute(30)]
        public string LastName { get; set; }

        [Required]
        [StringLengthAttribute(50)]
        public string Email { get; set; }

        [Required]
        [StringLengthAttribute(30)]
        public string UserName { get; set; }

        [Required]
        public string Password {get; set;}

        public string UnitNumber { get; set; }
        public string StreetNumber {get; set;}
        public string StreetName { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string ZipCode { get; set; }

        [Required]
        public string City { get; set; }
        public string PONumber { get; set; }
        

    }
}