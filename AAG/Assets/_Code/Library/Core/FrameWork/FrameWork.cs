using System;
using System.Collections;
using UnityEngine;

namespace Library
{
    public class FrameWork : MonoBehaviour
    {
        private static GameObject _rootObject;
        private static FrameWork _instance;
        
        public static bool HasInstance
        {
            get
            {
                return _instance != null;
            }
        }

        public static FrameWork Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GameObject("GameRoot").AddComponent<FrameWork>();
                }
                
                return _instance;
            }
        }

        public void Awake()
        {
            _instance = this;
            _rootObject = gameObject;

            StartCoroutine(DelayInitComponents());
        }

        IEnumerator DelayInitComponents()
        {
            yield return null;
            InitComponents();
        }

        private void InitComponents()
        {
            //TryAddComponent<>();    
        }


        private void Update()
        {
            
            GameFrameManager.Instance.Update();
            
        }

        public static int FrameRate = 30;
        public static float DeltaTime = 1 / FrameRate;
    }
}
