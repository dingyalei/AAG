using UnityEngine;

//namespace Log
//{
    public static class Log
    {
        public static void Error(string fmt, params object[] objects)
        {
            if (objects == null || objects.Length == 0)
            {
                Debug.LogError(fmt);
            }
            else
            {
                Debug.LogErrorFormat(fmt, objects);
            }
        }

        public static void Warning(string fmt, params object[] objects)
        {
            if (objects == null || objects.Length == 0)
            {
                Debug.LogWarning(fmt);
            }
            else
            {
                Debug.LogWarningFormat(fmt, objects);
            }
        }

        public static void Info(string fmt, params object[] objects)
        {
            if (objects == null || objects.Length == 0)
            {
                Debug.Log(fmt);
            }
            else
            {
                Debug.LogFormat(fmt, objects);
            }
        }

        public static void Assert(bool condition, string fmt, params object[] objects)
        {
            if (condition)
            {
                return;
            }
            
            Info(fmt, objects);
        }
    }
//}