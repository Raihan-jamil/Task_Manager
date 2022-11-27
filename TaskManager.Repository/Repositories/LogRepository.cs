using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Database.Context;
using TaskManager.Database.Models;
using TaskManager.Repository.Contracts;

namespace TaskManager.Repository.Repositories
{
    public class LogRepository : ILogRepository
    {
        private readonly TaskManagerContext _taskManagerContext;
        public LogRepository(TaskManagerContext taskManagerContext)
        {
            _taskManagerContext = taskManagerContext;
        }

        public async Task CreateLog(Log log)
        {
            _taskManagerContext.Logs.Add(log);
            await _taskManagerContext.SaveChangesAsync();
        }
    }
}
