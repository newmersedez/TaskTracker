using System;
using System.Collections.Generic;
using TaskTracker.Models;

namespace TaskTracker.Services
{
    public interface ITaskTrackerService
    {
        void CreateNewTaskEntity(TaskEntityType dtoType, DateTime dtoExpireDate, string dtoDescription);
        void EditTaskEntity(Guid dtoId, TaskEntityType dtoType, DateTime dtoExpireDate, string dtoDescription);
        void DeleteTaskEntity(Guid dtoId);
        void MarkTaskEntityAsFinished(Guid dtoId);
        public TaskEntity GetTaskEntityById(Guid id);
        public IEnumerable<TaskEntity> GetAllTaskEntities();
    }
}