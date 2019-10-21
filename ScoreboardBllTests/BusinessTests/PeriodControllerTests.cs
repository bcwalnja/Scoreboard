using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScoreboardBLL;

namespace ScoreboardBllTests
{
    [TestClass]
    public class PeriodControllerTests
    {
        protected IDisposable[] disposables;
        private PeriodController _periodController;
        private bool methodWasCalled;

        [TestInitialize]
        public void TestInitialize()
        {
            _periodController = PeriodController.GetPeriodController();
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

        private void PeriodControllerTests_PeriodChange(object sender, PeriodChangeEventArgs e)
        {
            methodWasCalled = true;
        }

        [TestMethod]
        public void IncrementPeriod_PeriodShouldBeCorrect()
        {
            //Arrange
            var period = _periodController.GetGamePeriod();

            //Act
            _periodController.IncrementPeriod();

            //Assert
            Assert.AreEqual(period + 1, _periodController.GetGamePeriod());
        }

        [TestMethod]
        public void ResetPeriod_PeriodShouldBeZero()
        {
            //Arrange
            var period = _periodController.GetGamePeriod();

            //Act
            _periodController.IncrementPeriod();
            _periodController.ResetPeriod();

            //Assert
            Assert.AreEqual(1, _periodController.GetGamePeriod());
        }

        [TestMethod]
        public void IncrementPeriod_PeriodShouldNotGoAboveFour()
        {
            //Arrange
            var period = _periodController.GetGamePeriod();

            //Act
            _periodController.ResetPeriod();
            Assert.AreEqual(1, _periodController.GetGamePeriod());
            _periodController.IncrementPeriod();
            Assert.AreEqual(2, _periodController.GetGamePeriod());
            _periodController.IncrementPeriod();
            Assert.AreEqual(3, _periodController.GetGamePeriod());
            _periodController.IncrementPeriod();
            Assert.AreEqual(4, _periodController.GetGamePeriod());
            _periodController.IncrementPeriod();
            Assert.AreEqual(1, _periodController.GetGamePeriod());
        }
    }
}