using System;
using UnityEngine;
using BallJumper.Interfaces;

namespace BallJumper.View
{
    public sealed class BallView : MonoBehaviour, IView, ICollidable, IMovable
    {
        public event Action<object, Collision2D> OnCollisionEnter2DEvent;

        private Rigidbody2D _rigidbody;
        private bool _rigidbodyIsNull;
        private Sprite _sprite;
        private bool _spriteIsNull;

        public Vector3 GetPosition { get => transform.position; }

        private void Awake()
        {
            _rigidbodyIsNull = !TryGetComponent(out _rigidbody);
            _spriteIsNull = !TryGetComponent(out _sprite);
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            OnCollisionEnter2DEvent?.Invoke(this, collision);
        }
        
        public void SetSprite(Sprite sprite)
        {
            if (_spriteIsNull) return;

            _sprite = sprite;
        }

        public void SetPosition(Vector2 position)
        {
            transform.position = position;
        }
        
        public void Show() => gameObject.SetActive(true);

        public void Hide() => gameObject.SetActive(false);

        public void Move(Vector2 direction)
        {
            if (_rigidbodyIsNull) return;

            _rigidbody.AddForce(direction);
        }
    }
}