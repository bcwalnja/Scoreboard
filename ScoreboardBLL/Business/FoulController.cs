using System.Collections.Generic;
using System.Linq;

namespace ScoreboardBLL
{
    public class FoulController
    {
        private static readonly FoulController _Instance = new FoulController();
        private static List<Foul> _TeamFouls;

        private FoulController()
        {
            _TeamFouls = new List<Foul>();
        }

        public static FoulController GetFoulController()
        {
            return _Instance;
        }

        public List<Foul> GetAllFouls()
        {
            return _TeamFouls;
        }

        public int GetTeamFouls(Team team)
        {
            return _TeamFouls.Where(x => x.Team == team).Count();
        }

        public void IncrementFouls(Team team)
        {
            _TeamFouls.Add(new Foul(team));
            //TODO: Fire "fouls changed event"
        }

        public void DecrementFouls(Team team)
        {
            Foul foul = _TeamFouls.FirstOrDefault(x => x.Team == team);
            if (foul != null)
            {
                _TeamFouls.Remove(foul);
            }

            //TODO: Fire "fouls changed event"
        }

        public void ResetAllFouls()
        {
            _TeamFouls.Clear();
            //TODO: Fire "fouls changed event"
        }
    }
}
