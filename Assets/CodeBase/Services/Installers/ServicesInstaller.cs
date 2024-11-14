using CodeBase.Services.Scene;
using Zenject;

namespace CodeBase.Services.Installers
{
    public class ServicesInstaller : MonoInstaller
    {
        
        public override void InstallBindings()
        {
            Container.Bind<SceneLoader>().AsSingle();
        }
    }
}