using System.Linq;

namespace ScoreboardBLL
{
    public static class GameFoulExtensions
    {
        public static int HomeFouls(this System.Collections.Generic.IEnumerable<Foul> fouls)
        {
            int homeFouls = 0;
            foreach (var foul in fouls)
            {
                if (foul.Team == Team.Home)
                {
                    homeFouls++; 
                }
            }
            return homeFouls;
        }

        public static int AwayFouls(this System.Collections.Generic.IEnumerable<Foul> fouls)
        {
            int awayFouls = 0;
            foreach (var foul in fouls)
            {
                if (foul.Team == Team.Away)
                {
                    awayFouls++; 
                }
            }
            return awayFouls;
        }

        public static bool HomeBonus(this System.Collections.Generic.IEnumerable<Foul> fouls)
        {
            return fouls.HomeFouls() > 6;
        }

        public static bool HomeDoubleBonus(this System.Collections.Generic.IEnumerable<Foul> fouls)
        {
            return fouls.HomeFouls() > 9;
        }

        public static bool AwayBonus(this System.Collections.Generic.IEnumerable<Foul> fouls)
        {
            return fouls.AwayFouls() > 6;
        }

        public static bool AwayDoubleBonus(this System.Collections.Generic.IEnumerable<Foul> fouls)
        {
            return fouls.AwayFouls() > 9;
        }
    }
}
