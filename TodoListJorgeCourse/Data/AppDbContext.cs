using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using TodoListJorgeCourse.Models;

namespace TodoListJorgeCourse.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TodoItem> TodoItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<TodoItem> list = new List<TodoItem>();
            for (int i = 1; i <= 1000; i++)
            {
                TodoItem ti = new() { TodoItemId = i, Title = $"t{i}", Description = $"d{i}", State = TaskState.InProgress};
                list.Add(ti);
            }
            modelBuilder.Entity<TodoItem>().HasData(list);


        }
    }
}
