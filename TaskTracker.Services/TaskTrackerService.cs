using System;
using TaskTracker.Models;
using TaskTracker.Persistence;

namespace TaskTracker.Services
{
    public class TaskTrackerService : ITaskTrackerService
    {
        private readonly TaskTrackerDbContext _context;

        public TaskTrackerService(TaskTrackerDbContext context)
        {
            _context = context;
        }

        public Guid AddNewTaskEntity(string name)
        {
            var task = new TaskEntity(name); //TODO: Guid создашь в конструкторе, там же валидация проверка на налл например
            _context.Add(task);
            return task.Id;
        }
    }
}