using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Habit
    {
        public Guid Id { get; set; }
        public List<TaskItem> TaskItems { get; set; }
        public string  Title { get; set; }
        public List<Goal> Goals { get; set; }
    }
}
