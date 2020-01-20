using BallJumper.Data;

namespace BallJumper.Controllers
{
    public sealed class MainMenuState : BaseGameState
    {
        public MainMenuState(GameStateController stateController, GameContext gameData) : base(stateController, gameData)
        {
            AddToLifecycleList(MainMenuControllerFactory.Instance.GetController(gameData));
            AddToLifecycleList(ScoreControllerFactory.Instance.GetController(gameData));
        }
    }
}