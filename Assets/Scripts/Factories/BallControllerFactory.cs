using UnityEngine;
using BallJumper.Interfaces;
using BallJumper.View;
using BallJumper.Controllers;
using BallJumper.Data;

namespace BallJumper
{
    public sealed class BallControllerFactory : Singleton<BallControllerFactory>, IControllerFactoryMethod
    {
        public IController GetController(GameContext gameData)
        {
            var view = Object.FindObjectOfType<BallView>();

            if (view == null)
            {
                var prefab = Resources.Load(ResourcesPaths.BallView) as GameObject;
                view = Object.Instantiate(prefab).GetComponent<BallView>();
            }

            return new BallController(view, gameData);
        }
    }
}
