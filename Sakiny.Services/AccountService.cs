using DoctorDiet.Repository.Interfaces;
using DoctorDiet.Repository.UnitOfWork;
using DoctorDiet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorDiet.Services
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
        
    }
}
