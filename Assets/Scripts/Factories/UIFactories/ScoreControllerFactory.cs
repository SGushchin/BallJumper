using UnityEngine;
using BallJumper.Interfaces;
using BallJumper.View;
using BallJumper.Controllers;
using BallJumper.Data;

namespace BallJumper
{
    public sealed class ScoreControllerFactory : BaseUIFactoryMethod<ScoreControllerFactory>
    {
        public override IController GetController(GameContext context)
        {
            var scorePanelPrefab = Resources.Load(ResourcesPaths.Score);
            var instanceMainMenu = Object.Instantiate(scorePanelPrefab, _canvas.transform) as GameObject;

            var view = instanceMainMenu.GetComponentInChildren<ScoreView>();

            return new ScoreController(view, context);
        }
    }
}
