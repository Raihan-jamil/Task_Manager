using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Database.Models
{
    public class Log
    {
        public int Id { get; set; }
        public DateTime IncomingTime { get; set; }
        public DateTime LeavingTime { get; set; }
    }
}
