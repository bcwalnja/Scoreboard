using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScoreboardBLL;

namespace ScoreboardBllTests
{
    [TestClass]
    public class ClockControllerTests
    {
        protected IDisposable[] disposables;
        private ClockController clockController;

        [TestInitialize]
        public void TestInitialize()
        {
            clockController = ClockController.GetClockController();
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
            var startingTime = new GameTime()
            {
                Minutes = 1
            };
            clockController.SetGameTime(startingTime);

            //Act
            EventMediator.GetEventMediator().OnGameClockTicks();
            var time = clockController.GetGameTime();

            //Assert
            Assert.AreEqual(0, time.Minutes);
            Assert.AreEqual(59, time.Seconds);
            Assert.AreEqual(9, time.Tenths);
        }
    }
}