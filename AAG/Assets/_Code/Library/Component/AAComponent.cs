namespace Library
{
    public abstract class AAComponent
    {
        //是否禁用改组件
        private bool _enable = true;

        public bool Enable
        {
            get => _enable && !_detached;
            set => _enable = value;
        }

        //是否挂载在角色上
        private bool _detached = true; 
        
        public bool Detached
        {
            get => _detached;
            set => _detached = value;
        }
        
        private object _ownerLogic;

        public object OwnerLogic => _ownerLogic;

        public virtual void AddComponent(object ownerLogic)
        {
            _ownerLogic = ownerLogic;
            RegisterEvent();
        }

        public virtual void RemoveComponent()
        {
            UnRegisterEvent();
            _ownerLogic = null;
        }
        
        protected virtual void RegisterEvent() { }

        protected virtual void UnRegisterEvent() { }

        public abstract uint AAComponentID
        {
            get;
        }

        public virtual void Update(float fDeltaT)
        {
            
        }

        public virtual void LateUpdate(float fDeltaT)
        {
            
        }
    }
}