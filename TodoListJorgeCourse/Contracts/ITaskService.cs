using TodoListJorgeCourse.Models;

namespace TodoListJorgeCourse.Contracts
{
    public interface ITaskService
    {
        Task<List<TodoItem>> GetTasksAsync(int pageNumber, int pageSize, TaskState? state = null);
        Task AddTaskAsync(TodoItem todoItem);
        Task DeleteTaskAsync(int taskId);
        Task UpdateTaskAsync(TodoItem todoItem);
        Task UpdateTaskStateAsync(int taskId, TaskState state);
    }
}
