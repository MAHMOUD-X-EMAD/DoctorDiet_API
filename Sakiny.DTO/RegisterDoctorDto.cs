using Sakiny.Models;
using System.ComponentModel.DataAnnotations;

namespace Sakiny.DTO
{
    public class RegisterDoctorDto: RegisterAdminDto
    {
        public string Specialization { get; set; }
        public string Location { get; set; }


    }
}