using System;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using TaskTracker.API.Dto;
using TaskTracker.Services;

namespace TaskTracker.API
{
    [Route("api/v1.0/[controller]")]
    public class TaskController
    {

        [Route("")]
        [HttpPost]
        public Guid AddNewTask([FromBody] AddNewTaskDto dto)
        {
            return new Guid();
            // return AddNewTaskEntity(dto.Name);
        }
    }
}