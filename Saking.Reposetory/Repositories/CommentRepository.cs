using Microsoft.EntityFrameworkCore.ChangeTracking;
using DoctorDiet.Data;
using DoctorDiet.Models;
using DoctorDiet.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;

namespace DoctorDiet.Repository.Reposetories
{
    public class CommentRepository : ICommentRepository 
    {
        Context _context;

        public CommentRepository(Context context)
        {
            _context = context;
        }
        //public Comment Add(Comment Comment)
        //{
        //    _context.comments.Add(Comment);

        //    return Comment;
        //}

        //public void Delete(int id)
        //{
        //    var entity = GetByCommentID(id);
        //    entity.IsDeleted = true;
        //}

        //public IQueryable<Comment> Get(System.Linq.Expressions.Expression<Func<Comment, bool>> expression)
        //{
        //    return _context.comments.Where(expression);
        //}

        //public Comment GetByCommentID(int id)
        //{
        //    return _context.comments.FirstOrDefault(x => x.Id == id);
        //}

        //public IQueryable<Comment> GetByApartmentID(int id)
        //{
        //    return _context.comments.Where(x => x.ApartmentId == id);
        //}

        //public void Update(Comment Comment)
        //{
        //    _context.Update(Comment);
        //}

        //public void Update(Comment Comment, params string[] properties)
        //{
        //    var localEntity = _context.comments.Local.Where(x => x.Id == Comment.Id).FirstOrDefault();

        //    EntityEntry entityEntry;

        //    if (localEntity is null)
        //    {
        //        entityEntry = _context.comments.Entry(Comment);
        //    }
        //    else
        //    {
        //        entityEntry =
        //            _context.ChangeTracker.Entries<Comment>()
        //            .Where(x => x.Entity.Id == Comment.Id).FirstOrDefault();
        //    }

        //    foreach (var property in entityEntry.Properties)
        //    {
        //        if (properties.Contains(property.Metadata.Name))
        //        {
        //            property.CurrentValue = Comment.GetType().GetProperty(property.Metadata.Name).GetValue(Comment);
        //            property.IsModified = true;
        //        }
        //    }
        //}

        //public void SaveChanges()
        //{
        //    _context.SaveChanges();
        //}
    }
}
