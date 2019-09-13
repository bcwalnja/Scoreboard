namespace ScoreboardBLL
{
    public class ScoreChangeEventArgs : System.EventArgs
    {
        public GameScore GameScore { get; }

        public ScoreChangeEventArgs(GameScore gameScore)
        {
            this.GameScore = gameScore;
        }
    }
}