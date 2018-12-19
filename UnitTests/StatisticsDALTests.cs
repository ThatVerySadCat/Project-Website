using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using DAL;
using Structs;

namespace UnitTests
{
    [TestClass]
    public class StatisticsDALTests
    {
        [TestMethod]
        public void GetEnemyCountPerDifficultyStatTest()
        {
            StatisticsDAL statisticsDAL = new StatisticsDAL();

            List<StatisticsData> datas = statisticsDAL.GetEnemyCountPerDifficultyStat();

            // Do Something
        }

        [TestMethod]
        public void GetEnemyCountPerUserStatTest()
        {
            StatisticsDAL statisticsDAL = new StatisticsDAL();

            List<StatisticsData> datas = statisticsDAL.GetEnemyCountPerUserStat();

            // Do Something
        }
    }
}
