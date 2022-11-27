using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Database.Models;

namespace TaskManager.Service.Contracts
{
    public interface ILogService
    {
        Task CreateLog(Log log);
    }
}
