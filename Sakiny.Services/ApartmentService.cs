using AutoMapper;
using AutoMapper.QueryableExtensions;
using Sakiny.DTO;
using Sakiny.Models;
using Sakiny.Repository.Interfaces;
using Sakiny.Repository.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sakiny.Services
{
    public class ApartmentService
    {
        IGenericRepository<Apartment,int> _repository;
        IUnitOfWork _unitOfWork;
        IMapper _mapper;
        ApartmentImageService _imageService;
    AddressService _addressService;
    AminitiesService _aminitiesService;

        public ApartmentService(IGenericRepository<Apartment, int> repository
            ,IUnitOfWork unitOfWork
            , IMapper mapper
            ,ApartmentImageService imageService
          ,AddressService addressService,
          AminitiesService aminitiesService)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _imageService = imageService;
            _addressService = addressService;
            _aminitiesService= aminitiesService;
        }

        public IEnumerable<ApartmentDTO> GetAll()
        {
            var apartments=_repository.GetAll();
            return apartments.ProjectTo<ApartmentDTO>(_mapper.ConfigurationProvider).ToList();
         }

        public ApartmentDTO GetById(int id)
        {
            Apartment apartment=_repository.GetByID(id);
           return _mapper.Map<ApartmentDTO>(apartment);
        }

        public IEnumerable<ApartmentDTO> GetAllByExprssion(Expression<Func<Apartment, bool>> expression)
        {
            var apartments = _repository.Get(expression);
            return apartments.ProjectTo<ApartmentDTO>(_mapper.ConfigurationProvider).ToList();
        }

        public ApartmentPostDTO Add(ApartmentPostDTO apartmentDTO)
        {

            Apartment apartment = _mapper.Map<Apartment>(apartmentDTO);
            Address address= _addressService.Add(apartmentDTO.Address);
            Aminities aminities = _aminitiesService.Add(apartmentDTO.Aminities);
            apartment.AddressId = address.Id;
            apartment.AminitiesId = aminities.Id;
            apartment.CreatedDate = DateTime.Now;
            apartment =  _repository.Add(apartment);
            _unitOfWork.SaveChanges();
            foreach (var item in apartmentDTO.ApartmentImages)
            {
                item.ApartmentId = apartment.Id;
                _imageService.Add(item);
            }
            return _mapper.Map<ApartmentPostDTO>(apartment);
        }

        public void Delete(int id) { 
            _repository.Delete(id);
        }

        public void Update(ApartmentDTO updateApartment, params string[] properties)
        {
            Apartment apartment = _mapper.Map<Apartment>(updateApartment);
           _repository.Update(apartment, properties);
            _unitOfWork.SaveChanges();
        }
    }
}
