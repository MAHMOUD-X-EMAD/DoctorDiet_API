using Sakiny.Models;
using Sakiny.Repository.Interfaces;
using Sakiny.Repository.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakiny.Services
{
  public class AminitiesService
  {
    IGenericRepository<Aminities, int> _repository;
    IUnitOfWork _unitOfWork;

    public AminitiesService(IGenericRepository<Aminities, int> repository
        , IUnitOfWork unitOfWork)
    {
      _repository = repository;
      _unitOfWork = unitOfWork;
    }
    public Aminities Add(Aminities aminities)
    {

      Aminities addAminities = _repository.Add(aminities);
      _unitOfWork.SaveChanges();
      return addAminities;

    }
  }
}
