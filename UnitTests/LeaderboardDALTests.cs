using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using DAL;
using Structs;

namespace UnitTests
{
    [TestClass]
    public class LeaderboardDALTests
    {
        [TestMethod]
        public void GetAllScoreDatasTest()
        {
            LeaderboardDAL leaderboardDAL = new LeaderboardDAL();

            List<ScoreData> scoreDatas = leaderboardDAL.GetAllScoreDatas();

            Assert.AreEqual(13, scoreDatas.Count);
        }
    }
}
