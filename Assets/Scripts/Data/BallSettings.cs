using UnityEngine;

namespace BallJumper.Data
{
    [CreateAssetMenu (fileName = "NewBallSettings", menuName = "Data/Ball/Create ball settings")]
    public class BallSettings : ScriptableObject
    {
        [SerializeField] private Sprite _ballSprite;

        public Sprite GetSprite { get => _ballSprite; }
    }
}
