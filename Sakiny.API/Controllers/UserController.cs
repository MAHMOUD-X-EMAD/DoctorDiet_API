﻿using Microsoft.AspNetCore.Mvc;
using DoctorDiet.Services;

namespace DoctorDiet.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
        {
            UserService userService;

            public UserController(UserService userService)
            {
                this.userService = userService;
            }


            //[HttpGet("userid")]
            //public IActionResult GetuserById (string userid)
            //{
            //    var user = userService.GetUserData(userid);

            //    return Ok(user);

            //}
        }
}
