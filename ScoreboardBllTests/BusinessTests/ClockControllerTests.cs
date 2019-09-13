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
        private bool methodWasCalled;

        [TestInitialize]
        public void TestInitialize()
        {
            clockController = ClockController.GetClockController();
            methodWasCalled = false;
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

        private void ClockControllerTests_ClockChange(object sender, ClockChangeEventArgs e)
        {
            methodWasCalled = true;
        }

        [TestMethod]
        public void SetClockForOneMinute_FireGameClockTick_ShouldBe59Seconds()
        {
            //Arrange
            var startingTime = new GameTime()
            {
                Minutes = 1
            };
            clockController.SetGameTime(startingTime);

            //Act
            clockController.DecrementGameTimeByTenth();
            var time = clockController.GetGameTime();

            //Assert
            Assert.AreEqual(0, time.Minutes);
            Assert.AreEqual(59, time.Seconds);
            Assert.AreEqual(9, time.Tenths);
        }

        [TestMethod]
        public void SubscribeToEvent_DecrementShouldFireEvent()
        {
            //Arrange
            EventMediator.GetEventMediator().ClockChange += ClockControllerTests_ClockChange;

            //Act
            clockController.DecrementGameTimeByTenth();

            //Assert
            Assert.IsTrue(methodWasCalled);
        }

        [TestMethod]
        public void SubscribeToEvent_SetGameTimeShouldFireEvent()
        {
            //Arrange
            EventMediator.GetEventMediator().ClockChange += ClockControllerTests_ClockChange;

            //Act
            clockController.SetGameTime(new GameTime());

            //Assert
            Assert.IsTrue(methodWasCalled);
        }

        [TestMethod]
        public void SetClockForOneTenth_FireDecrementTwice_ShouldNotGoNegative()
        {
            //Arrange
            var startingTime = new GameTime()
            {
                Tenths = 1
            };
            clockController.SetGameTime(startingTime);

            //Act
            clockController.DecrementGameTimeByTenth();
            clockController.DecrementGameTimeByTenth();
            var time = clockController.GetGameTime();

            //Assert
            Assert.AreEqual(0, time.Minutes);
            Assert.AreEqual(0, time.Seconds);
            Assert.AreEqual(0, time.Tenths);
        }

        [TestMethod]
        public void SetClockForNegativeTime_ShouldNotGoNegative()
        {
            //Arrange
            var startingTime = new GameTime()
            {
                Tenths = -1,
                Seconds = -1,
                Minutes = -1
            };
            clockController.SetGameTime(startingTime);

            //Act
            var time = clockController.GetGameTime();

            //Assert
            Assert.AreEqual(0, time.Minutes);
            Assert.AreEqual(0, time.Seconds);
            Assert.AreEqual(0, time.Tenths);
        }
    }
}