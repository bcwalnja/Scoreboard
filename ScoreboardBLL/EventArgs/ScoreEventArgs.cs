namespace ScoreboardBLL
{
    public class ScoreEventArgs : System.EventArgs
    {
        public Team Team { get; }
        public int Points { get; }

        public ScoreEventArgs(Team team, int points)
        {
            this.Team = team;
            this.Points = points;
        }
    }
}
