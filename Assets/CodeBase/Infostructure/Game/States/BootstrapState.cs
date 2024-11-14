using CodeBase.Infostructure.Game.APIs.States;
using CodeBase.Infostructure.IDs;
using CodeBase.Services.Scene;
using Zenject;

namespace CodeBase.Infostructure.Game.States
{
    public class BootstrapState : IState
    {
        private SceneLoader _sceneLoader;
        private GameStateMachine _gameStateMachine;

        [Inject]
        public BootstrapState(SceneLoader sceneLoader, GameStateMachine gameStateMachine)
        {
            _sceneLoader = sceneLoader;
            _gameStateMachine = gameStateMachine;
        }
        public void Exit()
        {
            
        }

        public void Enter()
        {
            _sceneLoader.LoadScene(SceneIDs.GameLoop, OnSceneLoaded);
        }

        private void OnSceneLoaded()
        {   
            _gameStateMachine.Enter<GameState, string>("level1");
        }
    }
}