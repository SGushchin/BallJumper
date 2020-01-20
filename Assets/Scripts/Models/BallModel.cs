using System;
using UnityEngine;


namespace BallJumper.Models
{
    public class BallModel
    {
        private readonly float MaxForce = Constants.MaxForceOfBallShift;

        public event Action<Vector2> OnApplyShiftForce;
        public event Action<Vector2> OnSetPosition;

        public Vector2 Position { get; private set; }

        public BallModel(Vector2 position)
        {
            SetPosition(position);
        }

        public void MoveToDirection(Vector2 direction)
        {
            var forceDirection = direction.normalized;
            forceDirection.y = 0f;
            forceDirection *= MaxForce;

            OnApplyShiftForce?.Invoke(forceDirection);
        }

        public void SetPosition(Vector2 newPosition)
        {
            UpdatePosition(newPosition);

            OnSetPosition?.Invoke(newPosition);
        }

        public void UpdatePosition(Vector2 newPosition)
        {
            Position = newPosition;

            if (Position.y < Constants.FallHeight)
            {
                SetPosition(Vector2.zero);
            }
        }
    }
}
