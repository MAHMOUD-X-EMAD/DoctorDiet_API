﻿using Microsoft.AspNetCore.Mvc;
using DoctorDiet.Services;

namespace DoctorDiet.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : Controller
    {

        OwnerService ownerService;

        public OwnerController(OwnerService CommentService)
        {
            ownerService = CommentService;
        }


        //[HttpGet("ownerid")]
        //public IActionResult GetOwnerById(string ownerid)
        //{
        //    var owner = ownerService.GetOwnerData(ownerid);

        //    return Ok(owner);
        
        //}
    }
}
