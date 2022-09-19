using Fluxor;
using FluxorWithBlazor.State.CurrentTitle;
using ToDoApp.Models;

namespace ToDoApp.State.ToDo;

public static class Reducers
{
    [ReducerMethod]
    public static ToDoState AddNewToDo(ToDoState toDoState, AddToDoStateAction addToDoStateAction) =>
        new(toDoItem: addToDoStateAction.ToDoItem);
    
    [ReducerMethod]
    public static ToDoState RemoveToDo(ToDoState toDoState, RemoveToDoAction removeToDoAction) =>
        new(toDoItem: removeToDoAction.ToDoItem);
    
    [ReducerMethod]
    public static ToDoState MarkToDoAsImportant(ToDoState toDoState, MarkAsImportantAction markAsImportantAction) =>
        new(toDoItem: markAsImportantAction.ToDoItems);
    
    [ReducerMethod]
    public static ToDoState UpdateToDoState(ToDoState toDoState, UpdateToDoStateAction updateToDoStateAction) =>
        new(toDoItem: updateToDoStateAction.ToDoItems);
    
    [ReducerMethod]
    public static ToDoState UnMarkAsImportant(ToDoState toDoState, UnMarkAsImportant unMarkAsImportant) =>
        new(toDoItem: unMarkAsImportant.ToDoItems);
    
    [ReducerMethod]
    public static ToDoState MarkAsComplete(ToDoState toDoState, MarkAsComplete markAsComplete) =>
        new(toDoItem: markAsComplete.ToDoItems);
    
    [ReducerMethod]
    public static ToDoState UnMarkAsComplete(ToDoState toDoState, UnMarkAsComplete unMarkAsComplete) =>
        new(toDoItem: unMarkAsComplete.ToDoItems);
    
}