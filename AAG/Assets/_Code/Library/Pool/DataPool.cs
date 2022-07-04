using System.Collections.Generic;
using System.Diagnostics;
namespace Library
{
    public class DataPool<T> where T : IPoolDataInterface, new()
    {
        private Stack<T> _stack;
        private int _nowCount;
        private const int CountMax = 6400;
        private static DataPool<T> _instance;
        
        public static DataPool<T> Instance
        {
            get
            {
                return _instance;
            }
        }

        static DataPool()
        {
            _instance = new DataPool<T>();
            _instance._stack = new Stack<T>();
            _instance._nowCount = 0;
        }

        public T Request()
        {
            T ret = default(T);
            if (_stack.Count <= 0)
            {
                ret = new T();
                CountNumHelp();
            }
            else
            {
                ret = _stack.Pop();
            }

            return ret;
        }

        public void Return(T t)
        {
            if (t == null)
            {
                return;
            }
            
            if (_stack.Count > 0 && object.ReferenceEquals(_stack.Peek(), t))
            {
                Log.Error("池内已经有了该对象，需要排查单一对象重复return");
                return;
            }

            StackCountHelp();    
            
            t.OnRecycle();
            _stack.Push(t);    
            
        }

        public void CleanUp()
        {
            _stack.Clear();
            ClearCountNum();
        }

        #region DebugHelper

        [Conditional("UNITY_EDITOR")]
        private void CountNumHelp()
        {
            _nowCount++;
            if (_nowCount > CountMax)
            {
                Log.Error("对象申请数量超出预取限制!!!");
            }
        }

        [Conditional("UNITY_EDITOR")]
        private void ClearCountNum()
        {
            _nowCount = 0;
        }

        [Conditional("UNITY_EDITOR")]
        private void StackCountHelp()
        {
            if (_stack.Count > CountMax)
            {
                Log.Error("注意对象池对象数量超出预期");
            }
        }

        #endregion
    }
}