using System.Collections.Generic;
using BallJumper.Interfaces;
using BallJumper.Data;


namespace BallJumper.Controllers
{
    public abstract class BaseGameState
    {
        protected GameStateController _stateController;
        protected GameContext _globalGameData;

        private List<IInitialize> _initializeControllers;
        private List<IExecute> _executeControllers;
        private List<ICleanup> _cleanupControllers;

        protected BaseGameState(GameStateController stateController, GameContext gameData)
        {
            _stateController = stateController;
            _globalGameData = gameData;

            _initializeControllers = new List<IInitialize>(Constants.DefaultArraySize);
            _executeControllers = new List<IExecute>(Constants.DefaultArraySize);
            _cleanupControllers = new List<ICleanup>(Constants.DefaultArraySize);
        }

        public virtual void Initialize()
        {
            for (var index = 0; index < _initializeControllers.Count; index++)
            {
                _initializeControllers[index].Initialize();
            }
        }

        public virtual void Execute()
        {
            for (var index = 0; index < _executeControllers.Count; index++)
            {
                _executeControllers[index].Execute();
            }
        }

        public virtual void Cleanup()
        {
            for (var index = 0; index < _cleanupControllers.Count; index++)
            {
                _cleanupControllers[index].Cleanup();
            }
        }

        protected void AddToLifecycleList(IController controller)
        {
            if (controller is IInitialize)
                _initializeControllers.Add(controller as IInitialize);

            if (controller is IExecute)
                _executeControllers.Add(controller as IExecute);

            if (controller is ICleanup)
                _cleanupControllers.Add(controller as ICleanup);
        }
    }
}
