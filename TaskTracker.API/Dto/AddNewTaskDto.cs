using System;

namespace TaskTracker.API.Dto
{
    public sealed class AddNewTaskDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
    }
}