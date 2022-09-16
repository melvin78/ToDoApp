using BlazorState;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ToDoApp.Features.CurrentTitle;

public partial class CurrentTitleState
{
    public class ChangeCurrentTitleHandler : ActionHandler<ChangeCurrentTitleAction>
    {
        public ChangeCurrentTitleHandler(IStore aStore) : base(aStore) { }


        public override Task<Unit> Handle(ChangeCurrentTitleAction changeCurrentTitleAction, CancellationToken aCancellationToken)
        {
            Title = changeCurrentTitleAction.CurrentTitle;
            
            var z = Title;
            
            return Unit.Task;
        }
    }
}