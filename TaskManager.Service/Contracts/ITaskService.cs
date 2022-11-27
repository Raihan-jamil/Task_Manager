using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Database.Models;
using TaskManager.Service.Helpers.DTOs;

namespace TaskManager.Service.Contracts
{
    public interface ITaskService
    {
        Task<TaskModel> CreateTask(TaskDto task);
        Task<List<TaskModel>> GetAllTasks();
        Task<TaskModel> UpdateTaskById(TaskDto task, int id);
        Task<List<TaskModel>> GetTasksOfAssignorWithName(string name);
        Task<List<TaskModel>> GetTasksOfAssigneeWithName(string name);
        Task<List<TaskModel>> GetTasksCompletedByPerson(string name);
        Task<Boolean> DeleteTask(int id);
        Task<TaskModel> GetTaskByDescription(string word);
    }
}
