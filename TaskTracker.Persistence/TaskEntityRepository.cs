using TaskTracker.Models;

namespace TaskTracker.Persistence
{
    public class TaskEntityRepository : ITaskEntityRepository
    {
        private readonly TaskTrackerDbContext _context;

        public TaskEntityRepository(TaskTrackerDbContext context)
        {
            _context = context;
        }

        public void Add(TaskEntity entity)
        {
            _context.TaskEntities.Add(entity);
        }

        public void Update(TaskEntity entity)
        {
            _context.TaskEntities.Update(entity);
        }

        public void Delete(TaskEntity entity)
        {
            _context.TaskEntities.Remove(entity);
        }
    }
}