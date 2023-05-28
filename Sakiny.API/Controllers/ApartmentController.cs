using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sakiny.DTO;
using Sakiny.Repository.UnitOfWork;
using Sakiny.Services;

namespace Sakiny.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApartmentController : ControllerBase
    {
        ApartmentService _apartmentService;
        IUnitOfWork _unitOfWork;
        public ApartmentController(ApartmentService apartmentService,IUnitOfWork unitOfWork) { 
            _apartmentService = apartmentService;
            _unitOfWork = unitOfWork;
        }

        [HttpGet("GetAllApartments")]
        public IActionResult GetAllApartments() { 
            List<ApartmentDTO> apartmentDTOs = (List<ApartmentDTO>)_apartmentService.GetAll();
            return Ok(apartmentDTOs);
        }

        [HttpGet("GetApartmentById")]
        public IActionResult GetApartmentById(int id)
        {
            ApartmentDTO apartmentDTO = _apartmentService.GetById(id);
            return Ok(apartmentDTO);
        }

        [HttpDelete("DeleteApartment")]
        public IActionResult DeleteApartment(int id)
        {
             _apartmentService.Delete(id);
            _unitOfWork.CommitChanges();

            return Ok("Deleted");
        }

        [HttpPost("AddApartment")]
        public IActionResult AddApartment(ApartmentPostDTO newApartment)
        {
            ApartmentPostDTO apartmentDTO = _apartmentService.Add(newApartment);
            _unitOfWork.CommitChanges();

            return Ok(apartmentDTO);
        }

      [HttpPut("UpdateApartment")]
      public IActionResult UpdateApartment(ApartmentDTO updateApartment, string[] updataedList)
      {
         string[] ListofUpdated = updataedList;
      _apartmentService.Update(updateApartment, ListofUpdated);
        _unitOfWork.CommitChanges();

        return Ok("Updated");
      }


  }
}
