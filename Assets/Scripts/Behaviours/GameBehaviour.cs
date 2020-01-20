using UnityEngine;
using BallJumper.Controllers;
using BallJumper.Data;
using BallJumper.Models;


namespace BallJumper.Behaviours
{
    public class GameBehaviour : MonoBehaviour
    {
        private GameStateController _gameController;

        private void Awake()
        {
            var player = new Player();

            var context = new GameContext()
            {
                Player = player
            };

            _gameController = GameStateController.Instance;
            var initialState = MainMenuStateFactory.Instance.GetState(_gameController, context);
            _gameController.SwitchState(initialState);
        }

        private void Update()
        {
            _gameController.Execute();
        }
    }
}
