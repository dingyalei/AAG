using System;
using System.Collections.Generic;

namespace Library
{
    public class AABaseAction
    {
    }
    
    public class AAAction : AABaseAction
    {
        private List<Action> _actionList;

        public AAAction()
        {
            _actionList = new List<Action>();
        }

        public void Invoke()
        {
            for (var i = 0; i < _actionList.Count; ++i)
            {
                if (_actionList[i] != null)
                {
                    _actionList[i].Invoke();
                }
            }
        }

        public void Register(Action action)
        {
            if (action == null)
            {
                return;
            }

            _actionList.Add(action);
        }

        public void UnRegister(Action action)
        {
            if (action == null)
            {
                return;
            }

            _actionList.Remove(action);
        }

        public void Clear()
        {
            _actionList.Clear();
        }

        public static AAAction operator +(AAAction aaAction, Action action)
        {
            aaAction.Register(action);
            return aaAction;
        }

        public static AAAction operator -(AAAction aaAction, Action action)
        {
            aaAction.UnRegister(action);
            return aaAction;
        }
    }

    public class AAAction<TP1> : AABaseAction
    {
        private List<Action<TP1>> _actionList;

        public AAAction()
        {
            _actionList = new List<Action<TP1>>();
        }

        public void Invoke(TP1 p1)
        {
            for (var i = 0; i < _actionList.Count; ++i)
            {
                if (_actionList[i] != null)
                {
                    _actionList[i].Invoke(p1);
                }
            }
        }

        public void Register(Action<TP1> action)
        {
            if (action == null)
            {
                return;
            }

            _actionList.Add(action);
        }

        public void UnRegister(Action<TP1> action)
        {
            if (action == null)
            {
                return;
            }

            _actionList.Remove(action);
        }

        public void Clear()
        {
            _actionList.Clear();
        }
        
        public static AAAction<TP1> operator +(AAAction<TP1> aaAction, Action<TP1> action)
        {
            aaAction.Register(action);
            return aaAction;
        }

        public static AAAction<TP1> operator -(AAAction<TP1> aaAction, Action<TP1> action)
        {
            aaAction.UnRegister(action);
            return aaAction;
        }
    }

    public class AAAction<TP1, TP2> : AABaseAction
    {
        private List<Action<TP1, TP2>> _actionList;

        public AAAction()
        {
            _actionList = new List<Action<TP1, TP2>>();
        }

        public void Invoke(TP1 p1, TP2 p2)
        {
            for (var i = 0; i < _actionList.Count; ++i)
            {
                if (_actionList[i] != null)
                {
                    _actionList[i].Invoke(p1, p2);
                }
            }
        }

        public void Register(Action<TP1, TP2> action)
        {
            if (action == null)
            {
                return;
            }

            _actionList.Add(action);
        }

        public void UnRegister(Action<TP1, TP2> action)
        {
            if (action == null)
            {
                return;
            }

            _actionList.Remove(action);
        }
        
        public void Clear()
        {
            _actionList.Clear();
        }

        public static AAAction<TP1, TP2> operator +(AAAction<TP1, TP2> aaAction, Action<TP1, TP2> action)
        {
            aaAction.Register(action);
            return aaAction;
        }

        public static AAAction<TP1, TP2> operator -(AAAction<TP1, TP2> aaAction, Action<TP1, TP2> action)
        {
            aaAction.UnRegister(action);
            return aaAction;
        }
    }
    
    public class AAAction<TP1, TP2, TP3> : AABaseAction
    {
        private List<Action<TP1, TP2, TP3>> _actionList;

        public AAAction()
        {
            _actionList = new List<Action<TP1, TP2, TP3>>();
        }

        public void Invoke(TP1 p1, TP2 p2, TP3 p3)
        {
            for (var i = 0; i < _actionList.Count; ++i)
            {
                if (_actionList[i] != null)
                {
                    _actionList[i].Invoke(p1, p2, p3);
                }
            }
        }

        public void Register(Action<TP1, TP2, TP3> action)
        {
            if (action == null)
            {
                return;
            }

            _actionList.Add(action);
        }

        public void UnRegister(Action<TP1, TP2, TP3> action)
        {
            if (action == null)
            {
                return;
            }

            _actionList.Remove(action);
        }
        
        public void Clear()
        {
            _actionList.Clear();
        }

        public static AAAction<TP1, TP2, TP3> operator +(AAAction<TP1, TP2, TP3> aaAction, Action<TP1, TP2, TP3> action)
        {
            aaAction.Register(action);
            return aaAction;
        }

        public static AAAction<TP1, TP2, TP3> operator -(AAAction<TP1, TP2, TP3> aaAction, Action<TP1, TP2, TP3> action)
        {
            aaAction.UnRegister(action);
            return aaAction;
        }
    }
    
    public class AAAction<TP1, TP2, TP3, TP4> : AABaseAction
    {
        private List<Action<TP1, TP2, TP3, TP4>> _actionList;

        public AAAction()
        {
            _actionList = new List<Action<TP1, TP2, TP3, TP4>>();
        }

        public void Invoke(TP1 p1, TP2 p2, TP3 p3, TP4 p4)
        {
            for (var i = 0; i < _actionList.Count; ++i)
            {
                if (_actionList[i] != null)
                {
                    _actionList[i].Invoke(p1, p2, p3, p4);
                }
            }
        }

        public void Register(Action<TP1, TP2, TP3, TP4> action)
        {
            if (action == null)
            {
                return;
            }

            _actionList.Add(action);
        }

        public void UnRegister(Action<TP1, TP2, TP3, TP4> action)
        {
            if (action == null)
            {
                return;
            }

            _actionList.Remove(action);
        }
        
        public void Clear()
        {
            _actionList.Clear();
        }

        public static AAAction<TP1, TP2, TP3, TP4> operator +(AAAction<TP1, TP2, TP3, TP4> aaAction, Action<TP1, TP2, TP3, TP4> action)
        {
            aaAction.Register(action);
            return aaAction;
        }

        public static AAAction<TP1, TP2, TP3, TP4> operator -(AAAction<TP1, TP2, TP3, TP4> aaAction, Action<TP1, TP2, TP3, TP4> action)
        {
            aaAction.UnRegister(action);
            return aaAction;
        }
    }
    
    public class AAAction<TP1, TP2, TP3, TP4, TP5> : AABaseAction
    {
        private List<Action<TP1, TP2, TP3, TP4, TP5>> _actionList;

        public AAAction()
        {
            _actionList = new List<Action<TP1, TP2, TP3, TP4, TP5>>();
        }

        public void Invoke(TP1 p1, TP2 p2, TP3 p3, TP4 p4, TP5 p5)
        {
            for (var i = 0; i < _actionList.Count; ++i)
            {
                if (_actionList[i] != null)
                {
                    _actionList[i].Invoke(p1, p2, p3, p4, p5);
                }
            }
        }

        public void Register(Action<TP1, TP2, TP3, TP4, TP5> action)
        {
            if (action == null)
            {
                return;
            }

            _actionList.Add(action);
        }

        public void UnRegister(Action<TP1, TP2, TP3, TP4, TP5> action)
        {
            if (action == null)
            {
                return;
            }

            _actionList.Remove(action);
        }
        
        public void Clear()
        {
            _actionList.Clear();
        }

        public static AAAction<TP1, TP2, TP3, TP4, TP5> operator +(AAAction<TP1, TP2, TP3, TP4, TP5> aaAction, Action<TP1, TP2, TP3, TP4, TP5> action)
        {
            aaAction.Register(action);
            return aaAction;
        }

        public static AAAction<TP1, TP2, TP3, TP4, TP5> operator -(AAAction<TP1, TP2, TP3, TP4, TP5> aaAction, Action<TP1, TP2, TP3, TP4, TP5> action)
        {
            aaAction.UnRegister(action);
            return aaAction;
        }
    }
}