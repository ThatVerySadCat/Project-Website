using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Logic;
using LogicInterfaces;

namespace IntegrationTests
{
    [TestClass]
    public class EnemyCollectionIntegrationTests
    {
        [TestMethod]
        public void GetAllEnemiesTest()
        {
            EnemyCollection enemyCollection = new EnemyCollection();

            bool actual = enemyCollection.GetAllEnemies();

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void GetAllEnemiesCountTest()
        {
            EnemyCollection enemyCollection = new EnemyCollection();

            enemyCollection.GetAllEnemies();

            Assert.AreEqual(8, enemyCollection.Enemies.Count);
        }

        [TestMethod]
        public void GetEnemyByIDTest()
        {
            EnemyCollection enemyCollection = new EnemyCollection();

            bool actual = enemyCollection.GetEnemyByID(0);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void GetEnemyByIDCreatorIDTest()
        {
            EnemyCollection enemyCollection = new EnemyCollection();

            enemyCollection.GetEnemyByID(0);

            Assert.AreEqual(0, enemyCollection.SelectedEnemy.CreatorID);
        }
    }
}
