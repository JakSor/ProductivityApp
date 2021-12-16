using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CustomUserClass : IdentityUser
    {
        List<TaskItem> Tasks { get; set; }
        public string CalendarId { get; set; }
    }
}
