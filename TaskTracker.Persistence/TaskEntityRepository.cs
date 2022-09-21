using System;
using System.Collections.Generic;
using System.Linq;
using TaskTracker.Models;

namespace TaskTracker.Persistence
{
    public sealed class TaskEntityRepository : ITaskEntityRepository
    {
        private readonly TaskTrackerDbContext _context;

        public TaskEntityRepository(TaskTrackerDbContext context)
        {
            _context = context;
        }

        public void Add(TaskEntity entity)
        {
            _context.TaskEntities.Add(entity);
            _context.SaveChanges();
        }

        public void Update(TaskEntity entity)
        {
            _context.TaskEntities.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(TaskEntity entity)
        {
            _context.TaskEntities.Remove(entity);
            _context.SaveChanges();
        }

        public TaskEntity GetById(Guid id)
        {
            return _context.TaskEntities.SingleOrDefault(x => x.Id == id);
        }

        public List<TaskEntity> GetAll()
        {
            return _context.TaskEntities.ToList();
        }
    }
}