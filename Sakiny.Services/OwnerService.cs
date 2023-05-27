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
    public class OwnerService
    {
        IGenericRepository<Owner,string> _repositry;

     public OwnerService(IGenericRepository<Owner,string> Repositry)
        {

            _repositry = Repositry;

        }

        public Owner GetOwnerData(string id)
        {


            Owner owner = _repositry.Get(o => o.Id==id).Include(x => x.ApplicationUser).FirstOrDefault();
            return owner;

        }
    }
}
