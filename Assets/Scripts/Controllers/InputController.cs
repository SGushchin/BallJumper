using UnityEngine;
using BallJumper.Data;
using BallJumper.Enums;
using BallJumper.Models;
using BallJumper.Interfaces;

namespace BallJumper.Controllers
{
    public sealed class InputController : IInitialize, IExecute
    {
        private readonly int _firstTouchElement = Constants.FirstTouchElement;
        private GameContext _context;
        private BallModel _ball;
        private bool isStandalone;

        public InputController(GameContext context)
        {
            _context = context;
        }

        public void Initialize()
        {
            _ball = _context.Ball;
#if UNITY_EDITOR || UNITY_STANDALONE

            isStandalone = true;

#elif UNITY_ANDROID || UNITY_IOS

            Input.multiTouchEnabled = false;
            isStandalone = false;

#endif
        }

        public void Execute()
        {
            var screenPosition = _ball.Position;
            

            if (isStandalone)
            {
                if (Input.GetMouseButton((int)MouseButton.Left))
                {
                    var x = Input.mousePosition.x;
                    var y = Input.mousePosition.y;
                    screenPosition = GetWorldPosition(new Vector2(x, y));
                }
            }
            else
            {
                var allTouches = Input.touches;

                if (allTouches.Length > 0)
                {
                    screenPosition = GetWorldPosition(allTouches[_firstTouchElement].position);
                }
            }

            if (screenPosition == _ball.Position) return;

            var shiftDirection = screenPosition - _ball.Position;
            _ball.MoveToDirection(shiftDirection);
        }

        private Vector2 GetWorldPosition(Vector2 position)
        {
            var screenPositionToWorld = Camera.main.ScreenToWorldPoint(position);
            return new Vector2(screenPositionToWorld.x, screenPositionToWorld.y);
        }
    }
}
