namespace ScoreboardBLL
{
    public class ScoreController
    {
        private static readonly ScoreController _Instance = new ScoreController();
        private static GameScore _CurrentScore;

        private ScoreController()
        {
            _CurrentScore = new GameScore();
        }

        public static ScoreController GetScoreController()
        {
            return _Instance;
        }

        private static void FireScoreChangedEventHandler()
        {
            EventMediator.GetEventMediator().OnScoreChange(_CurrentScore);
        }

        public GameScore GetCurrentScore()
        {
            return _CurrentScore;
        }

        public void ScoreEvent(Team team, int points)
        {
            if (team == Team.Away)
            {
                _CurrentScore.AwayScore += points;
                _CurrentScore.AwayScore = _CurrentScore.AwayScore < 0 ? 0 : _CurrentScore.AwayScore;
            }
            else
            {
                _CurrentScore.HomeScore += points;
                _CurrentScore.HomeScore = _CurrentScore.HomeScore < 0 ? 0 : _CurrentScore.HomeScore;
            }
            FireScoreChangedEventHandler();
        }

        public void SetGameScore(GameScore gameScore)
        {
            gameScore.HomeScore = gameScore.HomeScore < 0 ? 0 : gameScore.HomeScore;
            gameScore.AwayScore = gameScore.AwayScore < 0 ? 0 : gameScore.AwayScore;

            _CurrentScore.HomeScore = gameScore.HomeScore;
            _CurrentScore.AwayScore = gameScore.AwayScore;
            FireScoreChangedEventHandler();
        }
    }
}