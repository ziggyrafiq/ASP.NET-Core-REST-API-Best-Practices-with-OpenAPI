using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ZR.CodeExample.Models
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext(DbContextOptions<TaskDbContext> options)
            : base(options)
        {
        }

        public DbSet<TaskModel> Tasks { get; set; }
    }
}
