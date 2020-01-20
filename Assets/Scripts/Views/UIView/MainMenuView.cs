using UnityEngine;
using UnityEngine.UI;
using BallJumper.Interfaces;

namespace BallJumper.View
{
    public class MainMenuView : MonoBehaviour, IView
    {
        public Button LoadEarthButton;
        public Button LoadMoonButton;
        public Button LoadJupiterButton;

        public void Show() =>
            gameObject.SetActive(true);
        

        public void Hide() =>
            gameObject.SetActive(false);
    }
}
