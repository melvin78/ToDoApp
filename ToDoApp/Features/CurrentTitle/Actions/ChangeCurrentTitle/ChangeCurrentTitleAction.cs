using BlazorState;

namespace ToDoApp.Features.CurrentTitle;

public partial class CurrentTitleState
{
    
    public  class ChangeCurrentTitleAction : IAction
    {
    
        public string? CurrentTitle { get; set; }
    
    }
}
