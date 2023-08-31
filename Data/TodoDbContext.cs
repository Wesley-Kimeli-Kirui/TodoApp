using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToDoApp.Entities;

namespace ToDoApp.Data
{
    public class TodoDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public DbSet<User> Users { get; set; }
        public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options)
        {

        }
    }
}