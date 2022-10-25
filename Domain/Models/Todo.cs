namespace Domain.Models;

public class Todo
{
    public int Id { get; set; }
    public User? Owner { get; }
    public string? Title { get; }
    public bool IsCompleted { get; set; }

    public Todo(User owner, string Title)
    {
        this.Owner = owner;
        this.Title = Title;
    }
}