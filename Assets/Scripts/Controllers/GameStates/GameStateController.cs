namespace BallJumper.Controllers
{
    public class GameStateController : Singleton<GameStateController>
    {
        private BaseGameState _state;
        
        public void SwitchState(BaseGameState state)
        {
            _state?.Cleanup();
            _state = state;
            _state?.Initialize();
        }

        public void Execute()
        {
            _state?.Execute();
        }
    }
}
