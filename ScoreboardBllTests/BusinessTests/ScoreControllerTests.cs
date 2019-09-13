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
        private bool methodWasCalled;

        [TestInitialize]
        public void TestInitialize()
        {
            scoreController = ScoreController.GetScoreController();
        }

        [TestCleanup]
        public virtual void TearDown()
        {
            methodWasCalled = false;
            if (disposables != null)
            {
                foreach (IDisposable disposable in disposables)
                {
                    disposable.Dispose();
                }
            }
        }

        private void ScoreControllerTests_ScoreChange(object sender, ScoreChangeEventArgs e)
        {
            methodWasCalled = true;
        }

        [TestMethod]
        public void HomeScoresThreePoints_ScoreShouldBeCorrect()
        {
            //Arrange
            var score = scoreController.GetCurrentScore();
            int originalHome = score.HomeScore;
            int originalAway = score.AwayScore;

            //Act
            scoreController.ScoreEvent(Team.Home, 3);

            //Assert
            Assert.AreEqual(originalHome + 3, score.HomeScore);
            Assert.AreEqual(originalAway, score.AwayScore);
        }

        [TestMethod]
        public void AwayScoresThreePoints_ScoreShouldBeCorrect()
        {
            //Arrange
            var score = scoreController.GetCurrentScore();
            int originalHome = score.HomeScore;
            int originalAway = score.AwayScore;

            //Act
            scoreController.ScoreEvent(Team.Away, 3);

            //Assert
            Assert.AreEqual(originalHome, score.HomeScore);
            Assert.AreEqual(originalAway + 3, score.AwayScore);
        }

        [TestMethod]
        public void RemovePoints_ScoreShouldNotGoNegative()
        {
            //Arrange
            scoreController.SetGameScore(new GameScore());
            var score = scoreController.GetCurrentScore();

            //Act
            scoreController.ScoreEvent(Team.Away, -3);
            scoreController.ScoreEvent(Team.Home, -3);

            //Assert
            Assert.AreEqual(0, score.HomeScore);
            Assert.AreEqual(0, score.AwayScore);
        }

        [TestMethod]
        public void SubscribeToEvent_ScoreEventShouldFire()
        {
            //Arrange
            EventMediator.GetEventMediator().ScoreChange += ScoreControllerTests_ScoreChange;

            //Act
            scoreController.ScoreEvent(Team.Away, 0);

            //Assert
            Assert.IsTrue(methodWasCalled);
        }

        [TestMethod]
        public void SubscribeToEvent_SetGameScoreShouldFire()
        {
            //Arrange
            EventMediator.GetEventMediator().ScoreChange += ScoreControllerTests_ScoreChange;

            //Act
            scoreController.SetGameScore(new GameScore());

            //Assert
            Assert.IsTrue(methodWasCalled);
        }
    }
}