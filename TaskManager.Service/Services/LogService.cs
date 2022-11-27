using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Database.Models;
using TaskManager.Repository.Contracts;
using TaskManager.Service.Contracts;

namespace TaskManager.Service.Services
{
    public class LogService : ILogService
    {
        private readonly ILogRepository _logRepository;
        public LogService(ILogRepository logRepository)
        {
            _logRepository = logRepository;
        }
        public async Task CreateLog(Log log)
        {
            await _logRepository.CreateLog(log);
        }
    }
}
