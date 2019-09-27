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
            _GameTime.Minutes = _GameTime.Minutes + adjust;
            SetGameTime(_GameTime);
        }

        public void AdjustSeconds(int adjust)
        {
            _GameTime.Seconds = _GameTime.Seconds + adjust;
            if (_GameTime.Seconds < 0)
            {
                _GameTime.Seconds = 59;
            }
            else if (_GameTime.Seconds > 59)
            {
                _GameTime.Seconds = 0;
            }
            SetGameTime(_GameTime);
        }

        public GameTime GetGameTime()
        {
            return _GameTime;
        }

        public void SetGameTime(GameTime gameTime)
        {
            _GameTime.Minutes = gameTime.Minutes < 0 ? 0 : gameTime.Minutes;
            _GameTime.Minutes = gameTime.Minutes > 59 ? 59 : gameTime.Minutes;
            _GameTime.Seconds = gameTime.Seconds < 0 ? 0 : gameTime.Seconds;
            _GameTime.Minutes = gameTime.Seconds > 59 ? 59 : gameTime.Seconds;
            _GameTime.Tenths = gameTime.Tenths < 0 ? 0 : gameTime.Tenths;
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
                //GAME IS OVER
                _GameTime.Tenths = 0;
                _GameTime.Seconds = 0;
                _GameTime.Minutes = 0;

                //TODO: Fire "game clock expired"
            }
            FireGameClockChangedEvent();
        }
    }
}