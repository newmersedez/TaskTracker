using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskTracker.Models;
using TaskTracker.Persistence;

namespace TaskTracker.Services
{
    public sealed class TaskTrackerService: ITaskTrackerService
    {
        private readonly TaskTrackerDbContext _context;

        public TaskTrackerService(TaskTrackerDbContext context)
        {
            _context = context;
        }

        public TaskEntity GetTaskEntityById(Guid id)
        {
            return _context.TaskEntities.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<TaskEntity> GetAllTaskEntities()
        {
            return _context.TaskEntities.ToList();
        }
        
        public void CreateNewTaskEntity(TaskEntityType type, DateTime expireDate, string description)
        {
            var task = new TaskEntity(type, expireDate, description);
            _context.Add(task);
            _context.SaveChanges();
        }
        
        public void EditTaskEntity(Guid id, TaskEntityType type, DateTime expireDate, string description)
        {
            var taskEntity = _context.TaskEntities.SingleOrDefault(x => x.Id == id);
            if (taskEntity != null)
            {
                taskEntity.Type = type;
                taskEntity.ExpireDate = expireDate;
                taskEntity.Description = description;
                _context.SaveChanges();
            }
        }
        
        public void DeleteTaskEntity(Guid id)
        {
            var taskEntity = _context.TaskEntities.SingleOrDefault(x => x.Id == id);
            if (taskEntity != null)
            {
                _context.Remove(taskEntity);
                _context.SaveChanges();
            }
        }
        
        public void MarkTaskEntityAsFinished(Guid id)
        {
            var taskEntity = _context.TaskEntities.SingleOrDefault(x => x.Id == id);
            if (taskEntity != null)
            {
                taskEntity.Finished = true;
                _context.SaveChanges();
            }
        }
    }
}