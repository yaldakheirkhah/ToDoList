namespace ToDoList.Models;

public abstract class Task
{
    public string? Name { get; set; }
    public DateTime FromDate { get; set; }
    public DateTime ToDate { get; set; }
    public IList<SubTask>? SubTasks{ get; set; }
}