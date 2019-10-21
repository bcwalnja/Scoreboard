using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScoreboardBLL;

namespace ScoreboardBllTests
{
    [TestClass]
    public class FoulControllerTests
    {
        protected IDisposable[] disposables;
        private FoulController _foulController;
        private bool methodWasCalled;

        [TestInitialize]
        public void TestInitialize()
        {
            _foulController = FoulController.GetFoulController();
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

        private void FoulControllerTests_FoulsChanged(object sender, FoulChangeEventArgs e)
        {
            methodWasCalled = true;
        }

        [TestMethod]
        public void AddFoulToHomeTeam_ShouldHaveOneFoul()
        {
            //Arrange //Act
            _foulController.ResetAllFouls();
            _foulController.IncrementFouls(Team.Home);

            //Assert
            Assert.AreEqual(1, _foulController.GetTeamFouls(Team.Home));
            Assert.AreEqual(0, _foulController.GetTeamFouls(Team.Away));
        }

        [TestMethod]
        public void AddFoulToAwayTeam_ShouldHaveOneFoul()
        {
            //Arrange //Act
            _foulController.ResetAllFouls();
            var fouls = _foulController.GetAllFouls();
            _foulController.IncrementFouls(Team.Away);

            //Assert
            Assert.AreEqual(0, fouls.HomeFouls());
            Assert.AreEqual(1, fouls.AwayFouls());
        }

        [TestMethod]
        public void DecrementHomeFouls_ShouldRemoveFoul()
        {
            //Arrange //Act
            _foulController.ResetAllFouls();
            var fouls = _foulController.GetAllFouls();
            _foulController.IncrementFouls(Team.Away);
            _foulController.IncrementFouls(Team.Away);
            _foulController.IncrementFouls(Team.Away);

            _foulController.DecrementFouls(Team.Away);

            //Assert
            Assert.AreEqual(0, fouls.HomeFouls());
            Assert.AreEqual(2, fouls.AwayFouls());
        }

        [TestMethod]
        public void DecrementHomeFouls_ShouldNotGoNegative()
        {
            //Arrange //Act
            _foulController.ResetAllFouls();
            var fouls = _foulController.GetAllFouls();
            _foulController.DecrementFouls(Team.Away);

            //Assert
            Assert.AreEqual(0, fouls.HomeFouls());
            Assert.AreEqual(0, fouls.AwayFouls());
        }

        [TestMethod]
        public void SubscribeToEvent_IncrementShouldFireEvent()
        {
            //Arrange
            EventMediator.GetEventMediator().FoulsChange += FoulControllerTests_FoulsChanged;

            //Act
            _foulController.IncrementFouls(Team.Away);

            //Assert
            Assert.IsTrue(methodWasCalled);
        }

        [TestMethod]
        public void SubscribeToEvent_DecrementShouldFireEvent()
        {
            //Arrange
            EventMediator.GetEventMediator().FoulsChange += FoulControllerTests_FoulsChanged;

            //Act
            _foulController.DecrementFouls(Team.Away);

            //Assert
            Assert.IsTrue(methodWasCalled);
        }

        [TestMethod]
        public void SubscribeToEvent_ResetShouldFireEvent()
        {
            //Arrange
            EventMediator.GetEventMediator().FoulsChange += FoulControllerTests_FoulsChanged;

            //Act
            _foulController.ResetAllFouls();

            //Assert
            Assert.IsTrue(methodWasCalled);
        }
    }
}