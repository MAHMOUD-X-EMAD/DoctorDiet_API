﻿using Microsoft.AspNetCore.Mvc;
using DoctorDiet.Services;

namespace DoctorDiet.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : Controller
    {

        AdminService adminService;

        public AdminController(AdminService adminService)
        {
            this.adminService = adminService;
        }


        [HttpGet("Adminid")]
        public IActionResult GetAdminById(string Adminid)
        {
            var Admin = adminService.GetAdminData(Adminid);

            return Ok(Admin);

        }
    }
}
