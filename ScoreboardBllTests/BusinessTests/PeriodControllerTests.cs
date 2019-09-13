using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScoreboardBLL;

namespace ScoreboardBllTests
{
    [TestClass]
    public class PeriodControllerTests
    {
        protected IDisposable[] disposables;
        private PeriodController periodController;
        private bool methodWasCalled;

        [TestInitialize]
        public void TestInitialize()
        {
            periodController = PeriodController.GetPeriodController();
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
        public void IncrementPeriod_ScoreShouldBeCorrect()
        {
            //Arrange

            //Act

            //Assert

        }
    }
}