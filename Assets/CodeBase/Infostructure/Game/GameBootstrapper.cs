using CodeBase.Infostructure.Game.States;
using UnityEngine;
using Zenject;

namespace CodeBase.Infostructure.Game
{
    public class GameBootstrapper : MonoBehaviour
    {
        private Game _gameInstance;
        
        [Inject]
        public void Construct(GameStateMachine stateMachine, DiContainer container)
        {
            _gameInstance = new Game(stateMachine, container);
        }
        
        private void Start()
        {
            _gameInstance.Start();
        }
    }
}