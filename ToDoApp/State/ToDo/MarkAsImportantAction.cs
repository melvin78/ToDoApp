using System;
using System.Collections.Generic;
using System.Linq;
using ToDoApp.Models;

namespace ToDoApp.State.ToDo;

public class MarkAsImportantAction
{
    public List<ToDoItem>? ToDoItems { get; }

    public MarkAsImportantAction(List<ToDoItem>? toDoItems, Guid id)
    {
        toDoItems.FirstOrDefault(x => x.Id == id).ToDoIdentifier = (int) ToDoIdentifier.Important;

        ToDoItems = toDoItems;
    }
}