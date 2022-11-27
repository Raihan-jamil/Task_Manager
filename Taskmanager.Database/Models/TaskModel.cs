using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Database.Models
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string AssignorsName { get; set; }
        public string AssigneesName { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
