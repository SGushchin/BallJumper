using UnityEngine;

namespace BallJumper.View
{
    public sealed class BackgroundView : MonoBehaviour
    {
        private SpriteRenderer _renderer;
        private bool _rendererIsNull;

        private void Awake()
        {
            _rendererIsNull = !TryGetComponent(out _renderer);
        }

        public bool GetSpriteRendedrer(out SpriteRenderer renderer)
        {
            renderer = _renderer;

            return !_rendererIsNull;
        }
    }
}