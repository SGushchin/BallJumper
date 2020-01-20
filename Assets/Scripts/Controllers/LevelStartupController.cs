using UnityEngine;
using BallJumper.Data;
using BallJumper.View;
using BallJumper.Interfaces;

namespace BallJumper.Controllers
{
    public sealed class LevelStartupController : IInitialize
    {
        private BackgroundView _view;
        private GameContext _context;

        public LevelStartupController(BackgroundView view, GameContext context)
        {
            _view = view;
            _context = context;
        }
        
        public void Initialize()
        {
            if (_view.GetSpriteRendedrer(out var renderer) && _context.WorldSettings is ExtendedWorldSettings)
            {
                var worldSettings = _context.WorldSettings as ExtendedWorldSettings;
                
                renderer.sprite = worldSettings.GetBackgroundSprite;
                renderer.color = worldSettings.GetSkyColor;

                var cameraHeight = Camera.main.orthographicSize * 2.0f;
                var sizeWidth = cameraHeight * (Screen.currentResolution.width / (float)Screen.currentResolution.height);
                var sizeHeight = cameraHeight;
                var size = new Vector2(sizeWidth, sizeHeight);
                renderer.size = size;
            }

            Physics2D.gravity = new Vector2(0.0f, _context.WorldSettings.GetGravityValue * -1.0f);
        }
    }
}