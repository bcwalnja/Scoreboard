using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScoreboardBLL;

namespace ScoreboardBllTests
{
    [TestClass]
    public class TimeoutControllerTests
    {
        protected IDisposable[] disposables;
        private TimeoutController timeoutController;
        private bool methodWasCalled;

        [TestInitialize]
        public void TestInitialize()
        {
            timeoutController = TimeoutController.GetTimeoutController();
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

        private void TimeoutControllerTests_ClockChange(object sender, TimeoutChangeEventArgs e)
        {
            methodWasCalled = true;
        }

        [TestMethod]
        public void IncrementTimeout_ShouldBeThirtySeconds()
        {
            timeoutController.ResetTimeout();
            Assert.AreEqual(0, timeoutController.GetSeconds());
            timeoutController.IncrementTimeoutSeconds();
            Assert.AreEqual(30, timeoutController.GetSeconds());
        }

        [TestMethod]
        public void IncrementTimeoutTwice_ShouldBeSixtySeconds()
        {
            timeoutController.ResetTimeout();
            Assert.AreEqual(0, timeoutController.GetSeconds());
            timeoutController.IncrementTimeoutSeconds();
            timeoutController.IncrementTimeoutSeconds();
            Assert.AreEqual(60, timeoutController.GetSeconds());
        }

        [TestMethod]
        public void IncrementTimeoutThreeTimes_ShouldBeSixtySeconds()
        {
            timeoutController.ResetTimeout();
            Assert.AreEqual(0, timeoutController.GetSeconds());
            timeoutController.IncrementTimeoutSeconds();
            timeoutController.IncrementTimeoutSeconds();
            timeoutController.IncrementTimeoutSeconds();
            Assert.AreEqual(60, timeoutController.GetSeconds());
        }

        [TestMethod]
        public void DecrementTimeout_ShouldNotGoBelowZero()
        {
            timeoutController.ResetTimeout();
            Assert.AreEqual(0, timeoutController.GetSeconds());
            timeoutController.DecrementTimeout();
            Assert.AreEqual(0, timeoutController.GetSeconds());
        }

        [TestMethod]
        public void IncrementTimeout_RunOneDecrement_ShouldBe29Seconds()
        {
            timeoutController.ResetTimeout();
            Assert.AreEqual(0, timeoutController.GetSeconds());
            timeoutController.IncrementTimeoutSeconds();
            Assert.AreEqual(30, timeoutController.GetSeconds());
            timeoutController.DecrementTimeout();
            Assert.AreEqual(29, timeoutController.GetSeconds());
        }

        [TestMethod]
        public void SubscribeToEvent_SetGameTimeShouldFireEvent()
        {
            //Arrange
            EventMediator.GetEventMediator().TimeoutChange += TimeoutControllerTests_ClockChange;

            //Act
            timeoutController.DecrementTimeout();

            //Assert
            Assert.IsTrue(methodWasCalled);
        }
    }
}