using AutoMapper;
using JetBrains.Annotations;
using Sakiny.DTO;
using Sakiny.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakiny.Profiles
{
    public class RegisterOwnerProfile:Profile
    {
        public RegisterOwnerProfile()
        {
          
                CreateMap<RegisterOwnerDto, ApplicationUser>();

        }
    }
}
