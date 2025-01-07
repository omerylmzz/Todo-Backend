namespace todoapp_backend.Models;

public class Task
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Title { get; set; } = null!;
    public string Content { get; set; } = null!;
}