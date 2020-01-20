using BallJumper.Controllers;
using BallJumper.Data;

namespace BallJumper.Interfaces
{
    public interface IStateFactoryMethod
    {
        BaseGameState GetState(GameStateController stateController, GameContext gameData);
    }
}
