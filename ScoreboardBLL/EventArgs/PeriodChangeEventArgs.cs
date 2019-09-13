namespace ScoreboardBLL
{
    public class PeriodChangeEventArgs : System.EventArgs
    {
        public int Period{ get; }

        public PeriodChangeEventArgs(int period)
        {
            this.Period = period;
        }
    }
}