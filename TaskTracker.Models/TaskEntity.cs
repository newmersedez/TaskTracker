using System;

namespace TaskTracker.Models
{
    public sealed class TaskEntity
    {
        public Guid Id { get; }
        public string Name { get; set; }

        public TaskEntity(string name)
        {
            Id = new Guid();
            Name = name;
        }
    }
}