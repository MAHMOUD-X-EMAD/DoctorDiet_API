using AutoMapper;
using Sakiny.DTO;
using Sakiny.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakiny.Profiles
{
    public class RegisterCookerProfile:Profile
    {
        public RegisterCookerProfile()
        {
            CreateMap<RegisterCookerDto, ApplicationUser>();

        }
    }
}
