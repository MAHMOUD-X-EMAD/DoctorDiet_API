﻿using DoctorDiet.Data;
using DoctorDiet.Models;
using DoctorDiet.Repository.Interfaces;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DoctorDiet.Repository.Repositories
{
    public class PlanRepository : IPlanRepository
    {
        Context _context;

        public PlanRepository(Context context)
        {
            _context = context;
        }

        public IQueryable<Plan> GetAll()
        {
            return _context.Plans;
        }

        public IQueryable<Plan> Get(Expression<Func<Plan, bool>> expression)
        {
            return _context.Plans.Where(expression);
        }

        public Plan GetByID(int id)
        {
            return _context.Plans.FirstOrDefault(x => EqualityComparer<int>.Default.Equals(x.Id, id));
        }

        public Plan Add(Plan entity)
        {

            _context.Plans.Add(entity);

            return entity;
        }

        public void Update(Plan entity)
        {
            _context.Update(entity);
        }

        public void Update(Plan entity, params string[] properties)
        {
            var localEntity = _context.Plans.Local.Where(x => EqualityComparer<int>.Default.Equals(x.Id, entity.Id)).FirstOrDefault();

            EntityEntry entityEntry;

            if (localEntity is null)
            {
                entityEntry = _context.Plans.Entry(entity);
            }
            else
            {
                entityEntry =
                    _context.ChangeTracker.Entries<Plan>()
                    .Where(x => EqualityComparer<int>.Default.Equals(x.Entity.Id, entity.Id)).FirstOrDefault();
            }

            foreach (var property in entityEntry.Properties)
            {
                if (properties.Contains(property.Metadata.Name))
                {
                    property.CurrentValue = entity.GetType().GetProperty(property.Metadata.Name).GetValue(entity);
                    property.IsModified = true;
                }
            }

        }

        public void Delete(int id)
        {
            var entity = GetByID(id);
            entity.IsDeleted = true;
        }

        public List<Day> GetDayList(int id)
        {
            return _context.Day.Where(x => x.PlanId == id).ToList();
        }
    }
}