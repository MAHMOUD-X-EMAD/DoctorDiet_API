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
    public class CustomPlanService
    {
        private ICustomPlanRepository _repository;

        public CustomPlanService(ICustomPlanRepository repository)
        {
            _repository = repository;
        }

        public IQueryable<CustomPlan> GetAllPlans()
        {
            return _repository.GetAll();
        }

        public IQueryable<CustomPlan> GetPlans(Expression<Func<CustomPlan, bool>> expression)
        {
            return _repository.Get(expression);
        }

        public CustomPlan GetPlanById(int id)
        {
            return _repository.GetByID(id);
        }

        public List<Day> GetDaysById(int id)
        {
            return _repository.GetDayList(id);
        }

        public CustomPlan AddPlan(CustomPlan plan)
        {
            return _repository.Add(plan);
        }

        public void UpdatePlan(CustomPlan plan)
        {
            _repository.Update(plan);
        }

        public void UpdatePlanProperties(CustomPlan plan, params string[] properties)
        {
            _repository.Update(plan, properties);
        }

        public void DeletePlan(int id)
        {
            _repository.Delete(id);
        }
    }
}
