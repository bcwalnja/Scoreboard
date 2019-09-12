namespace ScoreboardBLL
{
    public class ScoreEventArgs : System.EventArgs
    {
        public Team Team { get; set; }
        public int Points { get; set; }

        public ScoreEventArgs(Team team, int points)
        {
            this.Team = team;
            this.Points = points;
        }
    }
}
