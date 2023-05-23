using Sakiny.Models;
using Sakiny.Models.Models_Images;
using System.ComponentModel.DataAnnotations;

namespace Sakiny.DTO
{
    public class RegisterOwnerDto: RegisterAdminDto
    {
        public OwnerImages IdntityImage { get; set; }  

    }
}