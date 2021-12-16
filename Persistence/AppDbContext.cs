using Application.Common.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class AppDbContext : IdentityDbContext<CustomUserClass>,IAppDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {}
        public DbSet<TaskItem> Tasks { get; set; }

    }
}
