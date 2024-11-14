namespace CodeBase.Infostructure.Game.APIs.States
{
    public interface IPayLoadState<T> : IExitableState
    {
        void Enter(T payLoad);
    }
}