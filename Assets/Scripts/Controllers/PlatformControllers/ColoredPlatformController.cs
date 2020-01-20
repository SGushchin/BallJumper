using System.Collections.Generic;
using UnityEngine;
using BallJumper.Interfaces;
using BallJumper.View;
using BallJumper.Models;

namespace BallJumper.Controllers
{
    public sealed class ColoredPlatformController : IInitialize, ICleanup
    {
        private ColoredPlatformView[] _platformViews;
        private Dictionary<ColoredPlatformView, ColoredPlatformModel> _platformModels;

        public ColoredPlatformController(ColoredPlatformView[] _platforms)
        {
            _platformViews = _platforms;
            
            InitializeDictionary();
        }

        public void Initialize()
        {
            foreach (var view in _platformModels.Keys)
            {
                _platformModels[view].OnSwithColor += view.SwitchColor;
                view.OnCollisionEnter2DEvent += CollisionHandler;

                view.Show();
            }
        }

        public void Cleanup()
        {
            foreach (var view in _platformModels.Keys)
            {
                view.Hide();

                _platformModels[view].OnSwithColor -= view.SwitchColor;
                view.OnCollisionEnter2DEvent -= CollisionHandler;
            }
        }

        private void InitializeDictionary()
        {
            _platformModels = new Dictionary<ColoredPlatformView, ColoredPlatformModel>(_platformViews.Length);

            for (var index = 0; index < _platformViews.Length; index++)
            {
                var model = new ColoredPlatformModel();
                _platformModels.Add(_platformViews[index], model);
                _platformViews[index].SwitchColor(model._curentColor);
            }
        }

        private void CollisionHandler(object obj, Collision2D collision)
        {
            if (collision.gameObject.CompareTag(Tags.Ball))
            {
                _platformModels[obj as ColoredPlatformView].SwitchColor();
            }
        }
    }
}
