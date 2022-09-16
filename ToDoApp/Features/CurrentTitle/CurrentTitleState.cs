using BlazorState;

namespace ToDoApp.Features.CurrentTitle;

public partial class CurrentTitleState: State<CurrentTitleState>
{
    public static string? Title { get; private  set; }
    
    public override void Initialize() => Title = "My Day";
}