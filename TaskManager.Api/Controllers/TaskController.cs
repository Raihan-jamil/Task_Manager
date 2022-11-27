using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Database.Models;
using TaskManager.Service.Contracts;
using TaskManager.Service.Helpers.DTOs;

namespace TaskManager.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService _taskService;
        private readonly ILogService _logService;
        public TaskController(ITaskService taskService,ILogService logService)
        {
            _taskService = taskService;
            _logService = logService;
        }
        [HttpPost("/api/tasks/")]
        public async Task<TaskModel> CreateTask(TaskDto task)
        {
            Log log = new Log();
            log.IncomingTime = DateTime.UtcNow;
            TaskModel taskModel = await _taskService.CreateTask(task);
            log.LeavingTime = DateTime.UtcNow;
            await _logService.CreateLog(log);
            return taskModel;
            
        }
        [HttpGet("/api/tasks/")]
        public async Task<List<TaskModel>> GetAllTasks()
        {
           return await _taskService.GetAllTasks();
        }
        [HttpPut("/api/tasks/{id}")]
        public async Task<TaskModel> UpdateTaskById(TaskDto task, int id)
        {
            return await _taskService.UpdateTaskById(task, id);
        }
        [HttpGet("/api/tasks/assignor/{name}")]
        public async Task<List<TaskModel>> GetTasksOfAssignorWithName(string name)
        {
            return await _taskService.GetTasksOfAssignorWithName(name);
        }
        [HttpGet("/api/tasks/assignee/{name}")]
        public async Task<List<TaskModel>> GetTasksOfAssigneeWithName(string name)
        {
            return await _taskService.GetTasksOfAssigneeWithName(name);
        }
        [HttpGet("/api/tasks/completed/{name}")]
        public async Task<List<TaskModel>> GetTasksCompletedByPerson(string name)
        {
            return await _taskService.GetTasksCompletedByPerson(name);
        }
        [HttpDelete("/api/tasks/{id}")]
        public async Task<Boolean> DeleteTask(int id)
        {
            return await _taskService.DeleteTask(id);
        }
        [HttpGet("/api/tasks/{word}")]
        public async Task<TaskModel> GetTaskByDescription(string word)
        {
            return await _taskService.GetTaskByDescription(word);
        }
    }
}
