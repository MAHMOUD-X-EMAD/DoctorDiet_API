using Sakiny.Models;
using Sakiny.Models.Models_Images;
using System.ComponentModel.DataAnnotations;

namespace Sakiny.DTO
{
    public class RegisterAdminDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }

        public string UserName { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string ContactInfo { get; set; }

        public string ProfileImage { get; set; }

    }
}