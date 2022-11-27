using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Service.Helpers.DTOs
{
    public class TaskDto
    {
        public string Description { get; set; }
        public string AssignorsName { get; set; }
        public string AssigneesName { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
