﻿using DoctorDiet.Models.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorDiet.Models
{
    public class PlanMealBridge:IBaseModel<int>
    {
        public int Id { get; set; }
        public int PlanId { get; set; }
        public int MealId { get; set; }
        public virtual Plan Plan { get; set; }
        public virtual Meal Meal { get; set; }

        [DefaultValue("false")]
        public bool IsDeleted { get; set; }

    }
}
