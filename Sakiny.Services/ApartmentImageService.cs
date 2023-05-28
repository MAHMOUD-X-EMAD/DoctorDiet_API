using AutoMapper;
using Sakiny.DTO;
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
    public class ApartmentImageService
    {
        IGenericRepository<ApartmentImages,int> _repository;
        IUnitOfWork _unitOfWork;
    IMapper _mapper;

        public ApartmentImageService(IGenericRepository<ApartmentImages, int> repository
            , IUnitOfWork unitOfWork,IMapper mapper)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
      _mapper = mapper;
        }
        public ApartmentImages Add(ApartmentImagesDTO apartmentImage)
        {
           ApartmentImages apartmentImages1= _mapper.Map<ApartmentImages>(apartmentImage);

            ApartmentImages apartmentImages = _repository.Add(apartmentImages1);
            _unitOfWork.SaveChanges();
            return apartmentImages;
            
        }
    }
}
