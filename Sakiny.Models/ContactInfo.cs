﻿using DoctorDiet.Models.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorDiet.Models
{
    public class ContactInfo:IBaseModel<int>
    {
         public string contactInfo { get; set; }
       public int Id { get; set; }
        [DefaultValue("false")]
        public bool IsDeleted { get; set; }
    }
}
