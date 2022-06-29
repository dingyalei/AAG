using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Utils
{
    public class Singleton<T> where T : class, new()
    {
        private static T instance;

        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new T();
                }
                return instance;
            }
        }
    }
    
    public class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
    {
        private static T instance;
        public static T Instance
        {
            get{return instance;}
        }
        
        protected virtual void Awake()
        {
            if (instance == null)
            {
                instance = (T)this;
            }
        }
    }
}

