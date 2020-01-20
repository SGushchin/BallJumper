using UnityEngine;
using BallJumper.Interfaces;
using BallJumper.View;
using BallJumper.Controllers;
using BallJumper.Data;

namespace BallJumper
{
    public sealed class BackToMainMenuControllerFactory : BaseUIFactoryMethod<BackToMainMenuControllerFactory>
    {
        public override IController GetController(GameContext context)
        {
            var backButtonPrefab = Resources.Load(ResourcesPaths.BackButton);
            var instance = Object.Instantiate(backButtonPrefab, _canvas.transform) as GameObject;

            var view = instance.GetComponent<BackToMainMenuButton>();

            return new BackToMainMenuController(view, context);
        }
    }
}
