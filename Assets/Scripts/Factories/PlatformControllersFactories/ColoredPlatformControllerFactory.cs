using UnityEngine;
using BallJumper.Interfaces;
using BallJumper.Controllers;
using BallJumper.Data;
using BallJumper.View;

namespace BallJumper
{
    public sealed class ColoredPlatformControllerFactory : Singleton<ColoredPlatformControllerFactory>, IControllerFactoryMethod
    {
        public IController GetController(GameContext context)
        {
            var views = Object.FindObjectsOfType<ColoredPlatformView>();
            if (views.Length <= 0)
            {
                var prefab = Resources.Load(ResourcesPaths.Platforms);
                var holder = Object.Instantiate(prefab) as GameObject;
                views = holder.GetComponentsInChildren<ColoredPlatformView>();
            }
            return new ColoredPlatformController(views);
        }
    }
}
