using UnityEngine;

namespace BallJumper.Data
{
    [CreateAssetMenu(fileName = "NewWorldSettings", menuName = "Data/World settings/Crete extended settings")]
    public sealed class ExtendedWorldSettings : BaseWorldSettings
    {
        [SerializeField, Tooltip("Color of the sky")] private Color _skyColor;

        public Color GetSkyColor { get => _skyColor; }
    }
}
