using System;
using System.Collections.Generic;
using System.Text;

namespace ScoreboardBLL
{
    public class ScoreController
    {
        private static readonly ScoreController _Instance = new ScoreController();
        private readonly GameScore CurrentScore;

        private ScoreController()
        {
            CurrentScore = new GameScore();
            EventMediator.GetEventMediator().ScoreAction += ScoreController_ScoreAction;
        }

        public static ScoreController GetScoreController()
        {
            return _Instance;
        }

        private void ScoreController_ScoreAction(object sender, ScoreEventArgs e)
        {
            if (e.Team == Team.Away)
            {
                CurrentScore.AwayScore += e.Points;
            }
            else
            {
                CurrentScore.HomeScore += e.Points;
            }
        }

        public GameScore GetCurrentScore()
        {
            return this.CurrentScore;
        }
    }
}