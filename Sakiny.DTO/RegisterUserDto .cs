using Sakiny.Models;
using Sakiny.Models.Models_Images;
using System.ComponentModel.DataAnnotations;

namespace Sakiny.DTO
{
    public class RegisterUserDto:RegisterAdminDto
    {
 
        public string NationalNumber { get; set; }

    }
}