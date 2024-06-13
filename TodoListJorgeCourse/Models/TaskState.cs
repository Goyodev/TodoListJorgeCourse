using TodoListJorgeCourse.Helpers;

namespace TodoListJorgeCourse.Models
{
    public enum TaskState
    {
        [Display("En progreso")]
        InProgress,

        [Display("Completado")]
        Completed,

        [Display("Bloqueado")]
        Blocked
    }
}
