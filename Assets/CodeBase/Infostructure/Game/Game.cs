
using CodeBase.Infostructure.Game.States;
using Zenject;

namespace CodeBase.Infostructure.Game
{
    
    public class Game
    {
        private readonly GameStateMachine _gameStateMachine;
        
        public Game(GameStateMachine gameStateMachine, DiContainer container)
        {
            _gameStateMachine = gameStateMachine;
            container.Bind<Game>().FromInstance(this);
        }
        
        public void Start()
        {
            _gameStateMachine.Enter<BootstrapState>();
        }
    }
}