//using DoctorDiet.DTO;
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
        void AddPatient(Patient Patient);
        
        void AddAdmin(Admin Admin);

        void AddDoctor(Doctor Doctor);
  
    }
}
