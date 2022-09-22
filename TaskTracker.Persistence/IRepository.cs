using System;
using System.Collections.Generic;
using TaskTracker.Models;

namespace TaskTracker.Persistence
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(Guid id);
        IEnumerable<T> GetAll();
    }
}