using System;
using System.Collections.Generic;
using System.Linq;
using ToDoApp.Models;

namespace ToDoApp.State.ToDo;

public class UnMarkAsImportant
{
    public List<ToDoItem> ToDoItems { get; }


    public UnMarkAsImportant(List<ToDoItem>? toDoItems, Guid id)
    {
        toDoItems.FirstOrDefault(x => x.Id == id).ToDoIdentifier = (int) ToDoIdentifier.MyDay;
        
        ToDoItems = toDoItems;
    }
}