namespace TwTodo.Models;

public class Todo {
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public DateTime CreateAt { get; set; }
    public DateOnly Deadline { get; set; }
}