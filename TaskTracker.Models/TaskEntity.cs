using System;

namespace TaskTracker.Models
{
    public enum TaskEntityType
    {
        WorkType,
        PersonalType
    }

    public sealed class TaskEntity
    {
        public Guid Id { get; init; }
        public TaskEntityType Type { get; set; }
        public DateTime ExpireDate { get; set; }
        public string Description { get; set; }
        public bool Finished { get; set; }

        public TaskEntity(TaskEntityType type, DateTime expireDate, string description)
        {
            if (description.Length == 0)
                throw new ArgumentException("Description is empty");
            if (expireDate <= DateTime.Now)
            {
                var time = DateTime.Now;
                throw new ArgumentException("Invalid expire data");
            }

            Id = new Guid();
            Type = type;
            ExpireDate = expireDate;
            Description = description;
            Finished = false;
        }
    }
}