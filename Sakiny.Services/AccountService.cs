using Sakiny.Repository.Interfaces;
using Sakiny.Repository.UnitOfWork;
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

        public void AddUser(Patient Patient)
        {
            _accountRepository.AddPatient(Patient);
            _UnitOfWork.SaveChanges();
        }
        
        public void AddAdmin(Admin Admin)
        {
            _accountRepository.AddAdmin(Admin);
            _UnitOfWork.SaveChanges();
        }
        public void AddDoctor(Doctor Doctor)
        {
          _accountRepository.AddDoctor(Doctor);
            _UnitOfWork.SaveChanges();
        }
        
    }
}
