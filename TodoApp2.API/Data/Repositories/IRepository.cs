using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace TodoApp2.API.Data.Repositories
{
    public interface IRepository<T> where T : class
    {
         void Add(T entity);
         void Update(T entity);
         void Delete(int id);
         T GetById(int id);
         IEnumerable<T> GetMany(Expression<Func<T,bool>> condition, Expression<Func<T,object>>[] properties);
         IEnumerable<T> GetAll();

    }
}