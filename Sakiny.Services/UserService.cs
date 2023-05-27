using Sakiny.Repository.Interfaces;
using Sakiny.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakiny.Services
{
    public class UserService
    {

        IGenericRepository<User> _repositry;

        public UserService(IGenericRepository<User> Repositry)
        {

            _repositry = Repositry;

        }

        public User GetUserData(string id)
        {
            User user = _repositry.Get(o => o.ApplicationUserId == id).FirstOrDefault();
            return user;

        }
    }
}
