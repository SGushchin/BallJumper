using BallJumper.Interfaces;
using BallJumper.View;

namespace BallJumper.Controllers
{
    public sealed class StandartPlatformController : IInitialize, ICleanup
    {
        private StandartPlatformView[] _platformViews;

        public StandartPlatformController(StandartPlatformView[] _platforms)
        {
            _platformViews = _platforms;
        }

        public void Initialize()
        {
            foreach (var view in _platformViews)
            {
                view.Show();
            }
        }

        public void Cleanup()
        {
            foreach (var view in _platformViews)
            {
                view.Hide();
            }
        }
    }
}
