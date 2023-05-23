using Sakiny.Models;
using Sakiny.Models.Models_Images;
using System.ComponentModel.DataAnnotations;

namespace Sakiny.DTO
{
    public class RegisterCookerDto: RegisterAdminDto
    {
        public bool Availablility { get; set; }    

    }
}