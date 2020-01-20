using BallJumper.Interfaces;
using BallJumper.View;
using BallJumper.Data;

namespace BallJumper.Controllers
{
    public sealed class BackToMainMenuController : IInitialize, ICleanup
    {
        private BackToMainMenuButton _view;
        private GameContext _context;

        public BackToMainMenuController(BackToMainMenuButton view, GameContext context)
        {
            _view = view;
            _context = context;
        }

        public void Initialize()
        {
            _view.BackButton.onClick.AddListener(ClickHandler);

            _view.Show();
        }

        public void Cleanup()
        {
            _view.Hide();

            _view.BackButton.onClick.RemoveListener(ClickHandler);
        }

        private void ClickHandler()
        {
            var stateController = GameStateController.Instance;
            var state = MainMenuStateFactory.Instance.GetState(stateController, _context);
            stateController.SwitchState(state);
        }
    }
}
