using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Identity.Client;
using Sakiny.Data;
//using DoctorDiet.DTO;
using Sakiny.Models;
using Sakiny.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakiny.Repository.Reposetories
{
    public class AccountRepository:IAccountRepository
    {
        Context _context;

        public AccountRepository(Context context)
        {
            _context = context;

        }
        public void AddAdmin(Admin Admin)
        {
            _context.Admin.Add(Admin);

        }

        public void AddPatient(Patient Patient)
        {
            _context.Patient.Add(Patient);

        }

        public void AddDoctor(Doctor Doctors)
        {
            _context.Doctors.Add(Doctors);

        }

    }
}
