using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using DAL;
using Structs;

namespace UnitTests
{
    [TestClass]
    public class EnemyDALTests
    {
        [TestMethod]
        public void GetEnemyDatasByUserIDTest()
        {
            EnemyDAL enemyDAL = new EnemyDAL();

            List<EnemyData> enemyDatas = enemyDAL.GetEnemyDatasByUserID(0);

            Assert.AreEqual(4, enemyDatas.Count);
        }

        [TestMethod]
        public void GetAllEnemyDatasTest()
        {
            EnemyDAL enemyDAL = new EnemyDAL();

            List<EnemyData> enemyDatas = enemyDAL.GetAllEnemyDatas();

            Assert.AreEqual(8, enemyDatas.Count);
        }

        [TestMethod]
        public void GetEnemyDataByIDTest()
        {
            EnemyDAL enemyDAL = new EnemyDAL();

            EnemyData enemyData = enemyDAL.GetEnemyDataByID(0);

            Assert.AreEqual("Enemy1", enemyData.Name);
        }
    }
}
