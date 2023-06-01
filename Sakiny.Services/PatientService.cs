﻿using Sakiny.Repository.Interfaces;
using Sakiny.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sakiny.Services
{
    public class PatientService
    { 
    
        IGenericRepository<Patient, string> _repositry;
        public PatientService(IGenericRepository<Patient, string> Repositry)
        {
            _repositry = Repositry;
        }
        public Patient GetPatientData(string id)
        {
            Patient patient = _repositry.Get(o => o.Id == id).Include(x => x.ApplicationUser).FirstOrDefault();
            return patient;

        }
    }
}
