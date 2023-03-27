namespace ToDoList.Models;

public abstract class SubTask
{
    public string? Description { get; set; }
    public bool IsCompleted { get; set; }
}