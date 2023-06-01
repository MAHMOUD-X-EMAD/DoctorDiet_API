using Sakiny.Repository.Interfaces;
using Sakiny.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sakiny.Services
{
    public class DoctorService
    {
        IGenericRepository<Doctor, string> _repositry;

        public DoctorService(IGenericRepository<Doctor, string> Repositry)
        {

            _repositry = Repositry;

        }

        public Doctor GetDoctorData(string id)
        {

            Doctor doctor = _repositry.Get(o => o.Id == id).Include(x => x.ApplicationUser).FirstOrDefault();
            return doctor;

        }
    }
}
