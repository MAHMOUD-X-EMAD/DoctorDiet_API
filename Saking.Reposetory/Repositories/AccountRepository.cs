using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Identity.Client;
using Sakiny.Data;
using Sakiny.DTO;
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
            _context=context;
         
        }

        public void AddUser(User User)
        {
            _context.users.Add(User);
        }
        public void AddOwner(Owner Owner)
        {
            _context.owners.Add(Owner);
        }
        public void AddAdmin(Admin Admin)
        {
            _context.admin.Add(Admin);
        }
        public void AddCooker(Cooker Cooker)
        {
            _context.cooker.Add(Cooker);
        }

       
    }
}
