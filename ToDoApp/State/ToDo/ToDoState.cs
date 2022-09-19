using Fluxor;
using ToDoApp.Models;

namespace ToDoApp.State.ToDo;

[FeatureState]
public class ToDoState
{
    public List<ToDoItem>? ToDoItem { get; } = new ();


    public ToDoState()
    {
        
    }

    public ToDoState(List<ToDoItem>? toDoItem)
    {
        ToDoItem = toDoItem;
    }
    
}