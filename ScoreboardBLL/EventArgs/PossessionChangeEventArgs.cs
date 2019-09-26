namespace ScoreboardBLL
{
    public class PossessionChangeEventArgs : System.EventArgs
    {
        public Team Team { get; }

        public PossessionChangeEventArgs(Team team)
        {
            this.Team = team;
        }
    }
}