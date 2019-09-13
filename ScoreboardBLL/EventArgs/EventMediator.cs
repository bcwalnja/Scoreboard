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

        public event EventHandler<FoulChangeEventArgs> FoulsChange;

        public void OnFoulsChange(GameFouls gameFouls)
        {
            FoulsChange?.Invoke(this, new FoulChangeEventArgs(gameFouls));
        }
    }
}
