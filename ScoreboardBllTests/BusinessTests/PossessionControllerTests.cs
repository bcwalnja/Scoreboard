using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScoreboardBLL;

namespace ScoreboardBllTests
{
    [TestClass]
    public class PossessionControllerTests
    {
        protected IDisposable[] disposables;
        private PossessionController _possessionController;
        private bool methodWasCalled;

        [TestInitialize]
        public void TestInitialize()
        {
            _possessionController = PossessionController.GetPossessionController();
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

        private void PossessionControllerTests_PossessionChange(object sender, PossessionChangeEventArgs e)
        {
            methodWasCalled = true;
        }

        [TestMethod]
        public void IncrementPossession_ShouldChangePossession()
        {
            //Arrange
            Team possession = _possessionController.GetCurrentPossession();

            //Act
            _possessionController.ChangePossession();

            //Assert
            Assert.AreNotEqual(possession, _possessionController.GetCurrentPossession());
        }

        [TestMethod]
        public void SubscribeToEvent_MethodShouldBeCalled()
        {
            //Arrange
            EventMediator.GetEventMediator().PossessionChange += PossessionControllerTests_PossessionChange;

            //Act
            _possessionController.ChangePossession();

            //Assert
            Assert.IsTrue(methodWasCalled);
        }
    }
}