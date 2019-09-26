using System;

namespace ScoreboardBLL
{
    public class TimeoutController
    {
        private static readonly TimeoutController _Instance = new TimeoutController();
        private static int Seconds;
        private TimeoutController() { }

        public static TimeoutController GetTimeoutController()
        {
            return _Instance;
        }

        public void IncrementTimeoutSeconds()
        {
            if (Seconds >= 30 && Seconds < 60)
            {
                Seconds = 60;
            }
            else if (Seconds < 30)
            {
                Seconds = 30;
            }
        }

        public void DecrementTimeout()
        {
            Seconds--;
            if (Seconds < 0)
            {
                //TIMEOUT IS OVER
                Seconds = 0;
                //TODO: Fire "game clock expired"
            }
            EventMediator.GetEventMediator().OnTimeoutChange(Seconds);
        }
    }
}