namespace ToDoApp.Models;

public class ToDoItem
{
    
    public int ToDoIdentifier { get; set; }
    public string? Title { get; set; }
    
    public Guid Id { get; set; }
    public bool IsDone { get; set; }
}