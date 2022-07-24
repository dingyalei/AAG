using System;
using UnityEngine;

namespace Library
{
    public class FrameAdvanceStrategyLocal : FrameAdvanceStrategy
    {
        public FrameAdvanceStrategyLocal(Action simulate) : base(simulate)
        {
            
        }

        public override void Advance()
        {
            AccumulatedTime += Time.deltaTime;
            while (AccumulatedTime >= FrameWork.DeltaTime)
            {
                ExecuteSimulate();
                
                AccumulatedTime -= FrameWork.DeltaTime;
            }
        }
    }
}