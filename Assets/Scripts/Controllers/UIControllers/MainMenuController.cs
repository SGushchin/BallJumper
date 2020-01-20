using UnityEngine;
using BallJumper.Interfaces;
using BallJumper.View;
using BallJumper.Data;

namespace BallJumper.Controllers
{
    public class MainMenuController : IInitialize, ICleanup
    {
        private MainMenuView _view;
        private GameContext _context;

        public MainMenuController(MainMenuView view, GameContext context)
        {
            _view = view;
            _context = context;
        }
        
        public void Initialize()
        {
            _view.LoadEarthButton.onClick.AddListener(LoadEarthHandler);
            _view.LoadMoonButton.onClick.AddListener(LoadMoonHandler);
            _view.LoadJupiterButton.onClick.AddListener(LoadJupiterHandler);

            _view.Show();
        }

        public void Cleanup()
        {
            _view.Hide();

            _view.LoadEarthButton.onClick.RemoveAllListeners();
            _view.LoadMoonButton.onClick.RemoveAllListeners();
            _view.LoadJupiterButton.onClick.RemoveAllListeners();
        }

        private void LoadEarthHandler()
        {
            _context.WorldSettings = Resources.Load(ResourcesPaths.EarthWorldSettings) as BaseWorldSettings;

            LoadGameplayState();
        }

        private void LoadMoonHandler()
        {
            _context.WorldSettings = Resources.Load(ResourcesPaths.MoonWorldSettings) as BaseWorldSettings;

            LoadGameplayState();
        }

        private void LoadJupiterHandler()
        {
            _context.WorldSettings = Resources.Load(ResourcesPaths.JupiterWorldSettings) as BaseWorldSettings;

            LoadGameplayState();
        }

        private void LoadGameplayState()
        {
            if (_context is null) return;

            var stateController = GameStateController.Instance;
            var state = GameplayStateFactory.Instance.GetState(stateController, _context);
            stateController.SwitchState(state);
        }
    }
}
