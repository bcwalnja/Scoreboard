namespace ScoreboardBLL
{
    public class TimeoutChangeEventArgs : System.EventArgs
    {
        public int Seconds { get; }

        public TimeoutChangeEventArgs(int seconds)
        {
            this.Seconds = seconds;
        }
    }
}