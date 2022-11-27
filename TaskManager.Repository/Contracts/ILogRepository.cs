using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Database.Models;

namespace TaskManager.Repository.Contracts
{
    public interface ILogRepository
    {
        Task CreateLog(Log log);
    }
}
