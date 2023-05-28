using Sakiny.Models;
using Sakiny.Models.Models_Images;
using Sakiny.Repository.Interfaces;
using Sakiny.Repository.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakiny.Services
{
  public class AddressService
  {
    IGenericRepository<Address, int> _repository;
    IUnitOfWork _unitOfWork;

    public AddressService(IGenericRepository<Address, int> repository
        , IUnitOfWork unitOfWork)
    {
      _repository = repository;
      _unitOfWork = unitOfWork;
    }
    public Address Add(Address address)
    {

      Address addAddress = _repository.Add(address);
      _unitOfWork.SaveChanges();
      return addAddress;

    }
  }
}
