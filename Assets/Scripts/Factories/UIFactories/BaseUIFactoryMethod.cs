using UnityEngine;
using BallJumper.Interfaces;
using BallJumper.Data;

namespace BallJumper
{
    public abstract class BaseUIFactoryMethod<T> : Singleton<T>, IControllerFactoryMethod where T : class, IControllerFactoryMethod
    {
        protected Canvas _canvas;
        protected bool _canvasIsNull = true;

        public BaseUIFactoryMethod()
        {
            _canvas = Object.FindObjectOfType<Canvas>();

            if (_canvas != null) _canvasIsNull = false;
        }

        public abstract IController GetController(GameContext gameData);
    }
}
