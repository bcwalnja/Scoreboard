using System;

namespace ScoreboardBLL
{
    public class PossessionController
    {
        private static readonly PossessionController _Instance = new PossessionController();
        private Team Team;

        private PossessionController()
        {
            this.Team = Team.Home;
        }

        public static PossessionController GetPossessionController()
        {
            return _Instance;
        }

        public Team GetCurrentPossession()
        {
            return this.Team;
        }

        public void ChangePossession()
        {
            if (Team == Team.Away)
            {
                Team = Team.Home;
            }
            else
            {
                Team = Team.Away;
            }
            EventMediator.GetEventMediator().OnPossessionChange(this.Team);
        }
    }
}