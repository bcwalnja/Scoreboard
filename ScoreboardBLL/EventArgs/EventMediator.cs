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

        public event EventHandler<ScoreEventArgs> ScoreAction;

        public void OnScoreAction(Team team, int points)
        {
            ScoreAction?.Invoke(this, new ScoreEventArgs(team, points));
        }

        public event EventHandler<EventArgs> GameClockTicks;

        public void OnGameClockTicks()
        {
            GameClockTicks?.Invoke(this, null);
        }
    }
}
