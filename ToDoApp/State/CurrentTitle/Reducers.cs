using Fluxor;

namespace FluxorWithBlazor.State.CurrentTitle
{
	public static class Reducers
	{
		[ReducerMethod]
		public static CurrentTitleState ChangeCurrentTitleAction(CurrentTitleState state, ChangeCurrentTitleAction action) =>
			new(currentTitle: action.CurrentTitle);
	}
}