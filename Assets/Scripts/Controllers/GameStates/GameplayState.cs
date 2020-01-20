using BallJumper.Data;

namespace BallJumper.Controllers
{
    public sealed class GameplayState : BaseGameState
    {
        public GameplayState(GameStateController stateController, GameContext context) : base(stateController, context)
        {
            AddToLifecycleList(LevelStartupControllerFactory.Instance.GetController(context));
            AddToLifecycleList(BackToMainMenuControllerFactory.Instance.GetController(context));
            AddToLifecycleList(ColoredPlatformControllerFactory.Instance.GetController(context));
            AddToLifecycleList(BallControllerFactory.Instance.GetController(context));
            AddToLifecycleList(InputControllerFactory.Instance.GetController(context));
        }
    }
}
