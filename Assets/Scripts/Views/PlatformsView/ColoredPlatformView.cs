using System;
using UnityEngine;
using BallJumper.Interfaces;

namespace BallJumper.View
{
    public sealed class ColoredPlatformView : MonoBehaviour, ICollidable, IView
    {
        public event Action<object, Collision2D> OnCollisionEnter2DEvent;

        private SpriteRenderer _spriteRenderer;
        private bool _spriteRendererIsNull = true;

        private void Awake()
        {
            _spriteRendererIsNull = !TryGetComponent(out _spriteRenderer);
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            OnCollisionEnter2DEvent?.Invoke(this, collision);
        }

        public void SwitchColor(Color color)
        {
            if (_spriteRendererIsNull) return;

            _spriteRenderer.color = color;
        }

        public void Show()
        {
            gameObject.SetActive(true);
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }
    }
}