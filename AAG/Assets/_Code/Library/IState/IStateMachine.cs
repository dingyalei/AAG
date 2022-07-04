namespace Library
{
    public class IStateMachine<T> where T : IState
    {
        public T CurrentState
        {
            get;
            protected set;
        }

        public T PreviousState
        {
            get;
            protected set;
        }

        void ChangeState(T nextState)
        {
            if (nextState != null && !Equals(nextState, CurrentState))
            {
                PreviousState = CurrentState;
                CurrentState = nextState;

                if (PreviousState != null)
                {
                    PreviousState.Exit();
                }
                
                CurrentState.Enter();
            }
        }
    }
}