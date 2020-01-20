using UnityEngine;
using BallJumper.Interfaces;
using BallJumper.Controllers;
using BallJumper.Data;
using BallJumper.View;

namespace BallJumper
{
    public sealed class StandartPlatformControllerFactory : Singleton<StandartPlatformControllerFactory>, IControllerFactoryMethod
    {
        public IController GetController(GameContext context)
        {
            var views = Object.FindObjectsOfType<StandartPlatformView>();
            if (views.Length <= 0)
            {
                var prefab = Resources.Load(ResourcesPaths.Platforms);
                var holder = Object.Instantiate(prefab) as GameObject;
                views = holder.GetComponentsInChildren<StandartPlatformView>();
            }
            return new StandartPlatformController(views);
        }
    }
}
