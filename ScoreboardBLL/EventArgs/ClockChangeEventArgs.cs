namespace ScoreboardBLL
{
    public class ClockChangeEventArgs : System.EventArgs
    {
        public GameTime GameTime { get; }

        public ClockChangeEventArgs(GameTime gameTime)
        {
            this.GameTime = gameTime;
        }
    }
}