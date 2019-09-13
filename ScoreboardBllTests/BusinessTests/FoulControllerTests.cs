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
            _foulController = FoulController.();
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
        public void Test01_AddFoulToHomeTeam_ShouldHaveOneFoul()
        {
            //Arrange //Act
            
            _foulController.IncrementFouls(Team.Home);

            //Assert
            Assert.AreEqual(1, _foulController.GetTeamFouls(Team.Home));
            Assert.AreEqual(0, _foulController.GetTeamFouls(Team.Away));
        }
    }
}