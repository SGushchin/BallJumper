using BallJumper.Data;

namespace BallJumper.Interfaces
{
    public interface IControllerFactoryMethod
    {
        IController GetController(GameContext context);
    }
}
