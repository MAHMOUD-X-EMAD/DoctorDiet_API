using DoctorDiet.Repository.Interfaces;
using DoctorDiet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DoctorDiet.Services
{
    public class CommentService
    {
        ICommentRepository _repository;

        public CommentService(ICommentRepository repository)
        {
            _repository = repository;
        }
        
        //public Comment Add(Comment branch)
        //{
        //    return _repository.Add(branch);
        //}


        //public IEnumerable<Comment> Get(Expression<Func<Comment, bool>> expression)
        //{
        //    return _repository.Get(expression);
        //}

        //public IEnumerable<Comment> GetByApartmentID(int id)
        //{
        //    return _repository.GetByApartmentID(id);
        //}

        //public Comment GetByCommentID(int id)
        //{
        //    return _repository.GetByCommentID(id);
        //}

        //public void Delete(int id)
        //{
        //    _repository.Delete(id);
        //}

        //public void SaveChanges()
        //{
        //    _repository.SaveChanges();
        //}
    }
}
