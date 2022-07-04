namespace Library
{
    public interface IState
    {
        void Enter();
        void Exit();
        void Update();
    }

    public interface ITState<T> : IState
    {
        T Subject
        {
            get;
            set;
        }
    }
}