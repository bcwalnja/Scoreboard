using System;

namespace ScoreboardBLL
{
    public class PeriodController
    {
        private static readonly PeriodController _Instance = new PeriodController();
        private static int _GamePeriod;

        private PeriodController() { }

        public static PeriodController GetPeriodController()
        {
            return _Instance;
        }

        public int GetGamePeriod()
        {
            return _GamePeriod;
        }

        public void IncrementPeriod()
        {
            _GamePeriod++;
        }

        public void ResetPeriod()
        {
            _GamePeriod = 0;
        }
    }
}