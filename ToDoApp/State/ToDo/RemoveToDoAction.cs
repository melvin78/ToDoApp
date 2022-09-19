using ToDoApp.Models;

namespace ToDoApp.State.ToDo;

public class RemoveToDoAction
{
    public List<ToDoItem>? ToDoItem { get; }

    public RemoveToDoAction(List<ToDoItem>? toDoItem,Guid id)
    {
         toDoItem?.RemoveAll(c => c.Id == id);

         ToDoItem = toDoItem;
    }
}