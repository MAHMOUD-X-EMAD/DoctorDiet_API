using Sakiny.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sakiny.Models;

namespace Sakiny.Services
{
    public class AdminService
    {

        IGenericRepository<Admin,string> _repositry;

      public AdminService(IGenericRepository<Admin,string> Repositry)
        {

            _repositry = Repositry;

        }

        public Admin GetAdminData(string id)
        {
            Admin Admin = _repositry.Get(o => o.Id == id).Include(x=> x.ApplicationUser).FirstOrDefault();
            return Admin;

        }
    }
}
