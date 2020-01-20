using UnityEngine;

namespace BallJumper.Data
{
    public abstract class BaseWorldSettings : ScriptableObject
    {
        [SerializeField, Tooltip("Set in m/s2")] private float _gravity;
        [SerializeField] private Sprite _backgroundSprite;

        public float GetGravityValue { get => _gravity; }
        public Sprite GetBackgroundSprite { get => _backgroundSprite; }
    }
}
