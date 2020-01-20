using UnityEngine;
using UnityEngine.UI;
using BallJumper.Interfaces;

namespace BallJumper.View
{
    public sealed class ScoreView : MonoBehaviour, IView
    {
        private Text _scoreText;
        private bool _scoreTextIsNull = true;

        private void Awake() =>
            _scoreTextIsNull = !TryGetComponent(out _scoreText);

        public void PrintScore(float score)
        {
            if (_scoreTextIsNull) return;

            var scoreText = score.ToString();
            _scoreText.text = scoreText;
        }

        public void Show() =>
            transform.parent.gameObject.SetActive(true);

        public void Hide() =>
            transform.parent.gameObject.SetActive(false);
    }
}