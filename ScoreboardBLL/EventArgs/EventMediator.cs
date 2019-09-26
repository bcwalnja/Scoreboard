using System;
using System.Collections.Generic;
using System.Text;

namespace ScoreboardBLL
{
    public class EventMediator
    {
        private static readonly EventMediator _Instance = new EventMediator();

        private EventMediator() { }

        public static EventMediator GetEventMediator()
        {
            return _Instance;
        }

        public event EventHandler<ScoreChangeEventArgs> ScoreChange;

        public void OnScoreChange(GameScore gameScore)
        {
            ScoreChange?.Invoke(this, new ScoreChangeEventArgs(gameScore));
        }

        public event EventHandler<ClockChangeEventArgs> ClockChange;

        public void OnClockChange(GameTime gameTime)
        {
            ClockChange?.Invoke(this, new ClockChangeEventArgs(gameTime));
        }

        public event EventHandler<TimeoutChangeEventArgs> TimeoutChange;

        public void OnTimeoutChange(int seconds)
        {
            TimeoutChange?.Invoke(this, new TimeoutChangeEventArgs(seconds));
        }

        public event EventHandler<PeriodChangeEventArgs> PeriodChange;

        public void OnPeriodChange(int period)
        {
            PeriodChange?.Invoke(this, new PeriodChangeEventArgs(period));
        }

        public event EventHandler<PossessionChangeEventArgs> PossessionChange;

        public void OnPossessionChange(Team team)
        {
            PossessionChange?.Invoke(this, new PossessionChangeEventArgs(team));
        }

        public event EventHandler<FoulChangeEventArgs> FoulsChange;

        public void OnFoulsChange(GameFouls gameFouls)
        {
            FoulsChange?.Invoke(this, new FoulChangeEventArgs(gameFouls));
        }
    }
}
