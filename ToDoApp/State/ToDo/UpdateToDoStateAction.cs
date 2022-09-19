using System.Collections.Generic;
using ToDoApp.Models;

namespace ToDoApp.State.ToDo;

public class UpdateToDoStateAction
{
    public List<ToDoItem> ToDoItems { get; }

    public UpdateToDoStateAction(List<ToDoItem> toDoItems, ToDoItem toDoItem)
    {
        toDoItems.Add(toDoItem);
        
        ToDoItems = toDoItems;
        
    }
}