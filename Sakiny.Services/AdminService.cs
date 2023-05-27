using Sakiny.Repository.Interfaces;
using Sakiny.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakiny.Services
{
    public class AdminService
    {

        IGenericRepository<Admin> _repositry;

      public AdminService(IGenericRepository<Admin> Repositry)
        {

            _repositry = Repositry;

        }

        public Admin GetAdminData(string id)
        {
            Admin Admin = _repositry.Get(o => o.ApplicationUserId == id).FirstOrDefault();
            return Admin;

        }
    }
}
