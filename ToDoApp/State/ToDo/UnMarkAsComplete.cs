using System;
using System.Collections.Generic;
using System.Linq;
using ToDoApp.Models;

namespace ToDoApp.State.ToDo;

public class UnMarkAsComplete
{
    public List<ToDoItem>? ToDoItems { get; }

    public UnMarkAsComplete(List<ToDoItem>? toDoItems,Guid id)
    {

        toDoItems.FirstOrDefault(x => x.Id == id).IsDone = false;
        
        ToDoItems = toDoItems;
    }
}