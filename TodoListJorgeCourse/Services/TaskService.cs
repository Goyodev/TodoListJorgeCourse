using Microsoft.EntityFrameworkCore;
using TodoListJorgeCourse.Contracts;
using TodoListJorgeCourse.Data;
using TodoListJorgeCourse.Models;

namespace TodoListJorgeCourse.Services
{
    public class TaskService:ITaskService
    {
        private readonly AppDbContext _context;

        public TaskService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<TodoItem>> GetTasksAsync(int pageNumber, int pageSize, TaskState? state = null)
        {
            var query = _context.TodoItems.AsQueryable();

            if (state.HasValue)
            {
                query = query.Where(t => t.State == state.Value);
            }

            return await query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
        }

        public async Task AddTaskAsync(TodoItem todoItem)
        {
            _context.TodoItems.Add(todoItem);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTaskAsync(int taskId)
        {
            var task = await _context.TodoItems.FindAsync(taskId);
            if (task != null)
            {
                _context.TodoItems.Remove(task);
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateTaskAsync(TodoItem task)
        {
            _context.TodoItems.Update(task);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateTaskStateAsync(int taskId, TaskState state)
        {
            var task = await _context.TodoItems.FindAsync(taskId);
            if (task != null)
            {
                task.State = state;
                await _context.SaveChangesAsync();
            }
        }
    }
}

