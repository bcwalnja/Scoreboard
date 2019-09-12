using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScoreboardBLL;

namespace ScoreboardBllTests
{
    [TestClass]
    public class ScoreControllerTests
    {
        protected IDisposable[] disposables;
        private ScoreController scoreController;

        [TestInitialize]
        public void TestInitialize()
        {
            scoreController = ScoreController.GetScoreController();
        }


        [TestCleanup]
        public virtual void TearDown()
        {
            
            if (disposables != null)
            {
                foreach (IDisposable disposable in disposables)
                {
                    disposable.Dispose();
                }
            }
        }

        [TestMethod]
        public void Test01_HomeScoresThreePoints_ScoreShouldBeCorrect()
        {
            //Arrange
            var eventMediator = EventMediator.GetEventMediator();

            //Act
            eventMediator.OnScoreAction(Team.Home, 3);

            //Assert
            Assert.AreEqual(3, scoreController.GetCurrentScore().HomeScore);
            Assert.AreEqual(0, scoreController.GetCurrentScore().AwayScore);
        }

        [TestMethod]
        public void Test02_AwayScoresThreePoints_ScoreShouldBeCorrect()
        {
            //Arrange
            var eventMediator = EventMediator.GetEventMediator();
            var score = scoreController.GetCurrentScore();
            int originalHome = score.HomeScore;
            int originalAway = score.AwayScore;

            //Act
            eventMediator.OnScoreAction(Team.Away, 3);

            //Assert
            Assert.AreEqual(originalHome, score.HomeScore);
            Assert.AreEqual(originalAway + 3, score.AwayScore);
        }
    }
}