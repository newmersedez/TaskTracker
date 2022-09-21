using System;
using TaskTracker.Models;

namespace TaskTracker.API.Dto
{
    public sealed class EditTaskDto
    {
        public Guid Id { get; set; }
        public TaskEntityType Type { get; set; }
        public string Description { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}