using System.Collections.Generic;
using System.Linq;

namespace ScoreboardBLL
{
    public class FoulController
    {
        private static readonly FoulController _Instance = new FoulController();
        private static GameFouls _GameFouls;

        private FoulController()
        {
            _GameFouls = new GameFouls(new List<Foul>());
        }

        public static FoulController GetFoulController()
        {
            return _Instance;
        }

        public GameFouls GetAllFouls()
        {
            return _GameFouls;
        }

        public int GetTeamFouls(Team team)
        {
            return _GameFouls.Where(x => x.Team == team).Count();
        }

        public void IncrementFouls(Team team)
        {
            _GameFouls.Add(new Foul(team));
            EventMediator.GetEventMediator().OnFoulsChange(_GameFouls);
        }

        public void DecrementFouls(Team team)
        {
            Foul foul = _GameFouls.FirstOrDefault(x => x.Team == team);
            if (foul != null)
            {
                _GameFouls.Remove(foul);
            }
            EventMediator.GetEventMediator().OnFoulsChange(_GameFouls);
        }

        public void ResetAllFouls()
        {
            _GameFouls.Clear();
            EventMediator.GetEventMediator().OnFoulsChange(_GameFouls);
        }
    }
}
