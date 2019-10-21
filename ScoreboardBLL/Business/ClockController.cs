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
        }

        public static ClockController GetClockController()
        {
            return _Instance;
        }

        public void AdjustMinutes(int adjust)
        {
            if ((adjust > 0 && _GameTime.Minutes < 59)
                || (adjust < 0 && _GameTime.Minutes > 0))
            {
                _GameTime.Minutes += adjust; 
            }
            FireGameClockChangedEvent();
        }

        public void AdjustSeconds(int adjust)
        {
            _GameTime.Seconds += adjust;
            if (_GameTime.Seconds < 0)
            {
                _GameTime.Seconds = 59;
            }
            else if (_GameTime.Seconds > 59)
            {
                _GameTime.Seconds = 0;
            }
            FireGameClockChangedEvent();
        }

        public GameTime GetGameTime()
        {
            return _GameTime;
        }

        public void SetGameTime(GameTime gameTime)
        {
            gameTime.Minutes = gameTime.Minutes < 0 ? 0 : gameTime.Minutes;
            gameTime.Minutes = gameTime.Minutes > 59 ? 59 : gameTime.Minutes;
            gameTime.Seconds = gameTime.Seconds < 0 ? 0 : gameTime.Seconds;
            gameTime.Seconds = gameTime.Seconds > 59 ? 59 : gameTime.Seconds;
            gameTime.Tenths = gameTime.Tenths < 0 ? 0 : gameTime.Tenths;
            gameTime.Tenths = gameTime.Tenths > 9 ? 9 : gameTime.Tenths;
            _GameTime = gameTime;
            FireGameClockChangedEvent();
        }

        private static void FireGameClockChangedEvent()
        {
            EventMediator.GetEventMediator().OnClockChange(_GameTime);
        }

        public void DecrementGameTimeByTenth()
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
                _GameTime.Tenths = 0;
                _GameTime.Seconds = 0;
                _GameTime.Minutes = 0;

                EventMediator.GetEventMediator().OnGameClockExpire();
            }
            FireGameClockChangedEvent();
        }
    }
}