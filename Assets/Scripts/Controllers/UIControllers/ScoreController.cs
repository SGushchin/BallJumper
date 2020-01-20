using BallJumper.Data;
using BallJumper.View;
using BallJumper.Interfaces;

namespace BallJumper.Controllers
{
    public sealed class ScoreController : IInitialize, ICleanup
    {
        private ScoreView _view;
        private GameContext _globalGameData;

        public ScoreController(ScoreView view, GameContext gameData)
        {
            _view = view;
            _globalGameData = gameData;
        }

        public void Initialize()
        {
            var score = Constants.DefaultScore;

            if (_globalGameData.Player is null)
                _view.PrintScore(score);
            else
                _view.PrintScore(_globalGameData.Player.Score);

            _view.Show();
        }

        public void Cleanup() => _view.Hide();
    }
}