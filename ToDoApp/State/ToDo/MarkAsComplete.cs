using System;
using System.Collections.Generic;
using System.Linq;
using ToDoApp.Models;

namespace ToDoApp.State.ToDo;

public class MarkAsComplete
{
    public List<ToDoItem>? ToDoItems { get; }

    public MarkAsComplete(List<ToDoItem>? toDoItems, Guid id)
    {
        toDoItems.FirstOrDefault(x => x.Id == id).IsDone = true;
        
        ToDoItems = toDoItems;
    }
}