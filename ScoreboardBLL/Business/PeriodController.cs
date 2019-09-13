using System;

namespace ScoreboardBLL
{
    public class PeriodController
    {
        private static readonly PeriodController _Instance = new PeriodController();
        private static GamePeriod _GamePeriod;

        private PeriodController()
        {
            _GamePeriod = new GamePeriod();
        }

        public static PeriodController GetPeriodController()
        {
            return _Instance;
        }

        public GameTime GetGamePeriod()
        {
            return _GamePeriod;
        }
    }
}