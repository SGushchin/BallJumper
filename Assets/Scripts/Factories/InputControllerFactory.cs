using BallJumper.Interfaces;
using BallJumper.Controllers;
using BallJumper.Data;

namespace BallJumper
{
    public sealed class InputControllerFactory : Singleton<InputControllerFactory>, IControllerFactoryMethod
    {
        public IController GetController(GameContext context)
        {
            return new InputController(context);
        }
    }
}
