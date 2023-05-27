using Sakiny.Repository.Interfaces;
using Sakiny.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakiny.Services
{
    public class OwnerService
    {
        IGenericRepository<Owner> _repositry;

     public OwnerService(IGenericRepository<Owner> Repositry)
        {

            _repositry = Repositry;

        }

        public Owner GetOwnerData(string id)
        {


            Owner owner = _repositry.Get(o => o.ApplicationUserId==id).FirstOrDefault();
            return owner;

        }
    }
}
