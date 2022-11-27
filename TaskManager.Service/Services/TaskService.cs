using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Database.Context;
using TaskManager.Database.Models;
using TaskManager.Repository.Contracts;
using TaskManager.Service.Contracts;
using TaskManager.Service.Helpers.DTOs;

namespace TaskManager.Service.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;
        public TaskService( ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<TaskModel> CreateTask(TaskDto task)
        {
            TaskModel taskModel = new TaskModel();

            taskModel.Status = task.Status;
            taskModel.AssigneesName = task.AssigneesName;
            taskModel.AssignorsName = task.AssignorsName;
            taskModel.Description = task.Description;
            taskModel.CreatedAt = task.CreatedAt;

            return await _taskRepository.CreateTask(taskModel);
        }
        public async Task<List<TaskModel>> GetAllTasks()
        {
            var tasks = await _taskRepository.GetAllTasks();
            return tasks;
        }
        public async Task<TaskModel> UpdateTaskById(TaskDto task, int id)
        {
            TaskModel taskModel = new TaskModel();

            taskModel.Status = task.Status;
            taskModel.AssigneesName = task.AssigneesName;
            taskModel.AssignorsName = task.AssignorsName;
            taskModel.Description = task.Description;
            taskModel.CreatedAt = task.CreatedAt;

            TaskModel task2 = await _taskRepository.UpdateTaskById(taskModel, id);
            return task2;
        }
        public async Task<List<TaskModel>> GetTasksOfAssignorWithName(string name)
        {
            var tasks = await _taskRepository.GetTasksOfAssignorWithName(name);
            return tasks;
        }
        public async Task<List<TaskModel>> GetTasksOfAssigneeWithName(string name)
        {
            var tasks = await _taskRepository.GetTasksOfAssigneeWithName(name);
            return tasks;
        }
        public async Task<List<TaskModel>> GetTasksCompletedByPerson(string name)
        {
            var tasks = await _taskRepository.GetTasksCompletedByPerson(name);
            return tasks;
        }
        public async Task<Boolean> DeleteTask(int id)
        {
            TaskModel task = await _taskRepository.GetTaskById(id);
            return await _taskRepository.DeleteTask(task);
        }
        public async Task<TaskModel> GetTaskByDescription(string word)
        {
            return await _taskRepository.GetTaskByDescription(word);
        }
    }
}
