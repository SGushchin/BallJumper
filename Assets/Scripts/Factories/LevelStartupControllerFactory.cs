using UnityEngine;
using BallJumper.Interfaces;
using BallJumper.Controllers;
using BallJumper.Data;

namespace BallJumper
{
    public sealed class LevelStartupControllerFactory : Singleton<LevelStartupControllerFactory>, IControllerFactoryMethod
    {
        public IController GetController(GameContext context)
        {
            var levelBg = Object.FindObjectOfType<View.BackgroundView>();

            return new LevelStartupController(levelBg, context);
        }
    }
}
