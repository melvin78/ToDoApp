using Fluxor;

namespace FluxorWithBlazor.State.CurrentTitle;

[FeatureState]
public class CurrentTitleState
{
    public string CurrentTitle { get; }

    public CurrentTitleState() { }
    
    public CurrentTitleState(string currentTitle)
    {
        CurrentTitle = string.IsNullOrEmpty(currentTitle) ? "My Day" : currentTitle;
    }
}