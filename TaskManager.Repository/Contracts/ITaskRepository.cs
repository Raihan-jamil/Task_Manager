using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Database.Models;

namespace TaskManager.Repository.Contracts
{
    public interface ITaskRepository
    {
        Task<TaskModel> CreateTask(TaskModel task);
        Task<List<TaskModel>> GetAllTasks();
        Task<TaskModel> GetTaskById(int id);
        Task<TaskModel> UpdateTaskById(TaskModel task, int id);
        Task<List<TaskModel>> GetTasksOfAssignorWithName(string name);
        Task<List<TaskModel>> GetTasksOfAssigneeWithName(string name);
        Task<List<TaskModel>> GetTasksCompletedByPerson(string name);
        Task<Boolean> DeleteTask(TaskModel task);
        Task<TaskModel> GetTaskByDescription(string word);

    }
}
