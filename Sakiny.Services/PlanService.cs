using Sakiny.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DoctorDiet.Models;
using DoctorDiet.Repository.Interfaces;
using System.Linq.Expressions;

namespace DoctorDiet.Services
{
    public class PlanService
    {
        private IPlanRepository _repository;

        public PlanService(IPlanRepository repository)
        {
            _repository = repository;
        }

        public IQueryable<Plan> GetAllPlans()
        {
            return _repository.GetAll();
        }

        public IQueryable<Plan> GetPlans(Expression<Func<Plan, bool>> expression)
        {
            return _repository.Get(expression);
        }

        public Plan GetPlanById(int id)
        {
            return _repository.GetByID(id);
        }

        public List<Day> GetDaysById(int id)
        {
            return _repository.GetDayList(id);
        }

        public Plan AddPlan(Plan plan)
        {
            return _repository.Add(plan);
        }

        public void UpdatePlan(Plan plan)
        {
            _repository.Update(plan);
        }

        public void UpdatePlanProperties(Plan plan, params string[] properties)
        {
            _repository.Update(plan, properties);
        }

        public void DeletePlan(int id)
        {
            _repository.Delete(id);
        }
    }
}
