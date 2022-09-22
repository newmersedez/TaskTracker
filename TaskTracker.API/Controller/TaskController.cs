using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TaskTracker.API.Dto;
using TaskTracker.Models;
using TaskTracker.Services;

namespace TaskTracker.API.Controller
{
    [ApiController]
    public sealed class TaskController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly ITaskTrackerService _service;

        public TaskController(ITaskTrackerService service)
        {
            _service = service;
        }
        
        [Route("")]
        [HttpPost]
        public void CreateTask([FromBody] CreateTaskDto dto)
        {
            _service.CreateNewTaskEntity(dto.Type, dto.ExpireDate, dto.Description);
        }
        
        [Route("/edit")]
        [HttpPut]
        public void EditTask([FromBody] EditTaskDto dto)
        {
            _service.EditTaskEntity(dto.Id, dto.Type, dto.ExpireDate, dto.Description);
        }
        
        [Route("/{id}")]
        [HttpDelete]
        public void DeleteTask(Guid id)
        {
            _service.DeleteTaskEntity(id);
        }
        
        [Route("/finish")]
        [HttpPut]
        public void MarkTaskAsFinished([FromBody] GetTaskByIdDto dto)
        {
            _service.MarkTaskEntityAsFinished(dto.Id);
        }
        
        [Route("/all")]
        [HttpGet]
        public IEnumerable<TaskEntity> GetAllTasks()
        {
            return _service.GetAllTaskEntities();
        }
        
        [Route("/{id}")]
        [HttpGet]
        public TaskEntity GetTaskById(Guid id)
        {
            return _service.GetTaskEntityById(id);
        }
    }
}