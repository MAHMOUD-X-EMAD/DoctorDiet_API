﻿using AutoMapper;
using DoctorDiet.DTO;
using DoctorDiet.Models;
using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakiny.Profiles
{
    public class RegisterDoctorProfile:Profile
    {
        public RegisterDoctorProfile()
        {
          
                CreateMap<RegisterDoctorDto, ApplicationUser>();

        }
    }
}
