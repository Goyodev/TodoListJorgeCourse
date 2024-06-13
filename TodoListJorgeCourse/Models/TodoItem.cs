using System.ComponentModel.DataAnnotations;

namespace TodoListJorgeCourse.Models
{
    public class TodoItem
    {
        public int TodoItemId { get; set; }
        [Required(ErrorMessage = "El titulo es obligatorio")]
        public string Title { get; set; }
        [Required(ErrorMessage = "La descripción es obligatoria")]
        public string Description { get; set; }
        [Required]
        public TaskState State { get; set; }
    }
}
