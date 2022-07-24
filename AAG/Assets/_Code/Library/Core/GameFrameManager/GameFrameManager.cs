namespace Library
{
    public class GameFrameManager
    {
        private static GameFrameManager _instance;
        public static GameFrameManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GameFrameManager();
                }

                return _instance;
            }
        }

        private FrameAdvanceStrategy _advanceStrategy;


        public void Update()
        {
            if (_advanceStrategy != null)
            {
                _advanceStrategy.Advance();
            }
        }
    }
}