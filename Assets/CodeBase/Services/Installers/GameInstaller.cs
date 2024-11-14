using CodeBase.Infostructure.Game;
using CodeBase.Infostructure.Game.States;
using Zenject;

namespace CodeBase.Services.Installers
{
    public class GameInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<GameBootstrapper>().FromComponentInHierarchy().AsSingle();

            Container.Bind<GameStateMachine>().FromNew().AsSingle();
        }
    }
}