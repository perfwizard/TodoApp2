using Microsoft.EntityFrameworkCore;
using TodoApp2.API.Models;

namespace TodoApp2.API.Data
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {}

        public DbSet<Task> Task { get; set; }
        public DbSet<TodoItem> TodoItem { get; set; }
        public DbSet<User> User { get; set; }


    }
}