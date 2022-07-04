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

        public void ChangeState(T nextState)
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

        public void Update()
        {
            if (CurrentState != null)
            {
                CurrentState.Update();
            }
        }
    }
}