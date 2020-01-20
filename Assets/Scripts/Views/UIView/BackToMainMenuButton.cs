using UnityEngine;
using UnityEngine.UI;
using BallJumper.Interfaces;

namespace BallJumper.View
{
    public sealed class BackToMainMenuButton : MonoBehaviour, IView
    {
        public Button BackButton;

        public void Hide()
        {
            gameObject.SetActive(false);
        }

        public void Show()
        {
            gameObject.SetActive(true);
        }
    }
}