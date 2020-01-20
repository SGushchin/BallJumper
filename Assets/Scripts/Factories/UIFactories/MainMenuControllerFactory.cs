using UnityEngine;
using BallJumper.Interfaces;
using BallJumper.Data;
using BallJumper.View;
using BallJumper.Controllers;

namespace BallJumper
{

    public sealed class MainMenuControllerFactory : BaseUIFactoryMethod<MainMenuControllerFactory>
    {
        public override IController GetController(GameContext gameData)
        {
            var mainMenuPrefab = Resources.Load(ResourcesPaths.MainMenu);
            var instanceMainMenu = Object.Instantiate(mainMenuPrefab, _canvas.transform) as GameObject;
            
            if (!instanceMainMenu.TryGetComponent<MainMenuView>(out var view))
                throw new System.ArgumentNullException("[MainMenuModel] not found");
            
            return new MainMenuController(view, gameData);
        }
    }
}
