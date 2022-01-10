using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Goal
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public List<TaskItem> TasksItem { get; set; }
        public TimeSpan Duration { get; set; }
        public string Category { get; set; }


    }
}
