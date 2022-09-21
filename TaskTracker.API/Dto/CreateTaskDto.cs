using System;
using TaskTracker.Models;

namespace TaskTracker.API.Dto
{
    public sealed class CreateTaskDto
    {
        public TaskEntityType Type { get; set; }
        public DateTime ExpireDate { get; set; }
        public string Description { get; set; }
    }
}