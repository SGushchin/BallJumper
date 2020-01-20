using BallJumper.Interfaces;
using BallJumper.Controllers;
using BallJumper.Data;

namespace BallJumper
{
    public sealed class MainMenuStateFactory : Singleton<MainMenuStateFactory>, IStateFactoryMethod
    {
        private BaseGameState _cashedState;

        public BaseGameState GetState(GameStateController stateController, GameContext gameData)
        {
            if (_cashedState is null)
            {
                _cashedState = new MainMenuState(stateController, gameData);
            }

            return _cashedState;
        }
    }
}
