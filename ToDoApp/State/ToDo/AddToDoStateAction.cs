using ToDoApp.Models;

namespace ToDoApp.State.ToDo;

public class AddToDoStateAction
{
    public List<ToDoItem>? ToDoItem { get; }

    public AddToDoStateAction(List<ToDoItem>? toDoItem)
    {
        
        ToDoItem = toDoItem;
    }
}