namespace FluxorWithBlazor.State.CurrentTitle;

    public class ChangeCurrentTitleAction
    {
        public string CurrentTitle { get; set; }
        public ChangeCurrentTitleAction(string currentTitle)
        {
            CurrentTitle = currentTitle;
        }
    }
