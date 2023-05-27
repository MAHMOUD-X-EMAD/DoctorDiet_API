using Sakiny.Repository.Interfaces;
using Saking.Reposetory.UnitOfWork;
using Sakiny.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakiny.Services
{
    public class AccountService
    {
        IUnitOfWork _UnitOfWork;
        IAccountRepository _accountRepository;

        public AccountService(IUnitOfWork unitOfWork, IAccountRepository accountRepository)
        {
            _UnitOfWork = unitOfWork;
            _accountRepository = accountRepository;
        }

        public void AddUser(User User)
        {
            _accountRepository.AddUser(User);
            _UnitOfWork.SaveChanges();
        }
        public void AddOwner(Owner Owner)
        {
            _accountRepository.AddOwner(Owner);
            _UnitOfWork.SaveChanges();
        }
        public void AddAdmin(Admin Admin)
        {
            _accountRepository.AddAdmin(Admin);
            _UnitOfWork.SaveChanges();
        }
        public void AddCooker(Cooker Cooker)
        {
            _accountRepository.AddCooker(Cooker);
            _UnitOfWork.SaveChanges();
        }
    }
}
