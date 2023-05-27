using Sakiny.DTO;
using Sakiny.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakiny.Repository.Interfaces
{
    public interface IAccountRepository
    {
        void AddUser(User User);
        void AddOwner(Owner Owner);
        void AddAdmin(Admin Admin);
        void AddCooker(Cooker Cooker);
    }
}
