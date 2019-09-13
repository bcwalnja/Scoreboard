namespace ScoreboardBLL
{
    public class Foul
    {
        public Team Team { get; set; }

        public Foul(Team team)
        {
            this.Team = team;
        }
    }
}