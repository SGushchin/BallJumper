using System;
using UnityEngine;
using BallJumper.Interfaces;

namespace BallJumper.View
{
    public sealed class StandartPlatformView : MonoBehaviour, ICollidable, IView
    {
        public event Action<object, Collision2D> OnCollisionEnter2DEvent;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            OnCollisionEnter2DEvent?.Invoke(this, collision);
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