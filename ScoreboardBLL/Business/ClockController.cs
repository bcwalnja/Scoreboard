using System;

namespace ScoreboardBLL
{
    public class ClockController
    {
        private static readonly ClockController _Instance = new ClockController();
        private static GameTime _GameTime;

        private ClockController()
        {
            _GameTime = new GameTime();
            EventMediator.GetEventMediator().GameClockTicks += ClockController_GameClockTicks;
        }

        public static ClockController GetClockController()
        {
            return _Instance;
        }

        private void ClockController_GameClockTicks(object sender, EventArgs e)
        {
            DecrementGameTimeByTenths();
        }

        public GameTime GetGameTime()
        {
            return _GameTime;
        }

        public void SetGameTime(GameTime gameTime)
        {
            _GameTime = gameTime;
        }

        private void DecrementGameTimeByTenths()
        {
            _GameTime.Tenths--;
            if (_GameTime.Tenths < 0)
            {
                _GameTime.Tenths = 9;
                _GameTime.Seconds--;
            }
            if (_GameTime.Seconds < 0)
            {
                _GameTime.Seconds = 59;
                _GameTime.Minutes--;
            }
            if (_GameTime.Minutes < 0)
            {
                //GAME IS OVER
                //(Code to handle that should probably go into whatever code handles the timer)
            }
        }
    }
}