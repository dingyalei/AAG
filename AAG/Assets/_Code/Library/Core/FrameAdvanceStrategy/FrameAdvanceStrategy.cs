using System;

namespace Library
{
    public class FrameAdvanceStrategy
    {
        protected readonly Action _simulate;
        
        protected float AccumulatedTime;

        public FrameAdvanceStrategy(Action simulate)
        {
            _simulate = simulate;
            AccumulatedTime = 0;
        }

        public virtual void Advance()
        {
            
        }
        
        protected void ExecuteSimulate()
        {
            try
            {
                if (_simulate != null)
                {
                    _simulate.Invoke();
                }
            }
            catch (Exception e)
            {
                Log.Error($"FrameAdvanceStrategy.ExecuteSimulate Exception: {e.ToString()}");
            }
        }
    }
}