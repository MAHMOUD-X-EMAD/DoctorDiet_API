using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//using DoctorDiet.Models;
using Sakiny.Services;

namespace Sakiny.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        CommentService _CommentService;

        public CommentController(CommentService CommentService)
        {
            _CommentService = CommentService;
        }

        //[HttpPost]
        //public IActionResult AddComment(Comment Comment)
        //{
        //    _CommentService.Add(Comment);

        //    _CommentService.SaveChanges();

        //    return Ok("Done");
        //}

        //[HttpGet("Apartmentid")]
        //public IActionResult GetByApartmentID(int Apartmentid)
        //{
        //    var comments = _CommentService.GetByApartmentID(Apartmentid);

        //    return Ok(comments);
        //}

       // [HttpGet("id")]
        //public IActionResult GetByCommentID(int id)
        //{
        //    var comment = _CommentService.GetByCommentID(id);

        //    return Ok(comment);
        //}

        //[HttpDelete("id")]
        //public IActionResult DeleteComment(int id)
        //{
        //    _CommentService.Delete(id);

        //    return Ok("Done");
        //}
    }
}
