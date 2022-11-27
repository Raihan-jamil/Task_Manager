using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Database.Context;
using TaskManager.Database.Models;
using TaskManager.Repository.Contracts;

namespace TaskManager.Repository.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly TaskManagerContext _taskManagerContext;

        public TaskRepository(TaskManagerContext taskManagerContext)
        {
            _taskManagerContext = taskManagerContext;
        }   

        public async Task<TaskModel> CreateTask(TaskModel task)
        {
            _taskManagerContext.Tasks.Add(task);
            await _taskManagerContext.SaveChangesAsync();
            return task;

        }
        public async Task<List<TaskModel>> GetAllTasks()
        {
            return await _taskManagerContext.Tasks.ToListAsync();
        }

        public async Task<TaskModel> GetTaskById(int id)
        {
            return await _taskManagerContext.Tasks.FindAsync(id);
        }
        public async Task<TaskModel> UpdateTaskById(TaskModel task, int id)
        {
            TaskModel task2 = await _taskManagerContext.Tasks.FindAsync(id);
            
            task2.Description = task.Description;
            task2.AssigneesName = task.AssigneesName;
            task2.AssignorsName = task.AssignorsName;
            task2.Status = task.Status;

            await _taskManagerContext.SaveChangesAsync();

            return task2;
        }
        public async Task<List<TaskModel>> GetTasksOfAssignorWithName(string name)
        {
            var tasks = await _taskManagerContext.Tasks.Where(task => task.AssignorsName == name).ToListAsync();
            return tasks;
        }
        public async Task<List<TaskModel>> GetTasksOfAssigneeWithName(string name)
        {
            var tasks = await _taskManagerContext.Tasks.Where(task => task.AssigneesName == name).ToListAsync();
            return tasks;
        }
        public async Task<List<TaskModel>> GetTasksCompletedByPerson(string name)
        {
            var tasks = await _taskManagerContext.Tasks
                .Where(task => task.AssigneesName == name && task.Status == "Completed")
                .ToListAsync();
            return tasks;
        }
        public async Task<Boolean> DeleteTask(TaskModel task)
        {
            _taskManagerContext.Tasks.Remove(task);
            await _taskManagerContext.SaveChangesAsync();
            return true;
        }
        public async Task<TaskModel> GetTaskByDescription(string word)
        {
            var task = await _taskManagerContext.Tasks
                .Where(task => task.Description.Contains(word))
                .FirstOrDefaultAsync();

            return task;
        }
    }
}
