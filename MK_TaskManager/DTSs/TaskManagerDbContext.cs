using MK_TaskManager.Models;
using System;
using System.Data.Entity;

namespace MK_TaskManager.DTSs
{
    public class TaskManagerDbContext : DbContext
    {
        public TaskManagerDbContext() : base("TasksDBConnectionString")
        {
        }

        public DbSet<Task> Tasks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<TaskComment> Comments { get; set; }
    }
}