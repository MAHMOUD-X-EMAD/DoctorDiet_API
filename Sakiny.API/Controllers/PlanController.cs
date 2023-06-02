using DoctorDiet.Models;
using DoctorDiet.Services;
using Microsoft.AspNetCore.Mvc;

namespace DoctorDiet.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanController : Controller
    {
        private PlanService _planService;

        public PlanController(PlanService planService)
        {
            _planService = planService;
        }

        [HttpGet]
        public IActionResult GetAllPlans()
        {
            var plans = _planService.GetAllPlans();
            return Ok(plans);
        }

        [HttpGet("{id}")]
        public IActionResult GetPlanById(int id)
        {
            var plan = _planService.GetPlanById(id);
            if (plan == null)
                return NotFound();
            return Ok(plan);
        }

        [HttpGet("Days/{id}")]
        public IActionResult GetDaysById(int id)
        {
            var days = _planService.GetDaysById(id);
            if (days == null)
                return NotFound();
            return Ok(days);
        }

        [HttpPost]
        public IActionResult AddPlan(Plan plan)
        {
            var addedPlan = _planService.AddPlan(plan);
            return Ok(addedPlan);
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePlan(int id, Plan plan)
        {
            if (id != plan.Id)
                return BadRequest();

            _planService.UpdatePlan(plan);
            return NoContent();
        }

        [HttpPatch("{id}")]
        public IActionResult UpdatePlanProperties(int id, Plan plan, params string[] properties)
        {
            if (id != plan.Id)
                return BadRequest();

            _planService.UpdatePlanProperties(plan, properties);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePlan(int id)
        {
            _planService.DeletePlan(id);
            return NoContent();
        }
    }
}
