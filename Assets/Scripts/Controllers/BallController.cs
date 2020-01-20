using UnityEngine;
using BallJumper.Interfaces;
using BallJumper.Data;
using BallJumper.View;
using BallJumper.Models;


namespace BallJumper.Controllers
{
    public sealed class BallController : IInitialize, IExecute, ICleanup
    {
        private BallView _view;
        private bool _viewIsNull = true;
        private GameContext _context;

        public BallController(BallView view, GameContext context)
        {
            _view = view;
            if (_view != null) _viewIsNull = false;
            _context = context;
        }
        
        public void Initialize()
        {
            if (_viewIsNull || _context is null) return;

            if (_context.Ball is null)
            {
                _context.Ball = new BallModel(Vector2.zero);
            }

            _context.Ball.OnApplyShiftForce += _view.Move;
            _context.Ball.OnSetPosition += _view.SetPosition;
            _view.OnCollisionEnter2DEvent += CollisionHandler;

            _view.SetPosition(_context.Ball.Position);

            _view.Show();
        }

        public void Execute()
        {
            if (_viewIsNull || _context is null) return;
            
            _context.Ball.UpdatePosition(_view.GetPosition);
        }

        public void Cleanup()
        {
            if (_viewIsNull || _context is null) return;

            _view.Hide();

            _context.Ball.OnApplyShiftForce -= _view.Move;
            _context.Ball.OnSetPosition -= _view.SetPosition;
            _view.OnCollisionEnter2DEvent -= CollisionHandler;
        }

        private void CollisionHandler(object obj, Collision2D collision)
        {
            if (collision.gameObject.CompareTag(Tags.Platform))
            {
                _context?.Player.IncrementScore();
            }
        }
    }
}
