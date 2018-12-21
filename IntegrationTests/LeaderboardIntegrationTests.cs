using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Logic;
using LogicInterfaces;

namespace IntegrationTests
{
    [TestClass]
    public class LeaderboardIntegrationTests
    {
        [TestMethod]
        public void GetAllGlobalEntriesTest()
        {
            Leaderboard leaderboard = new Leaderboard();

            bool actual = leaderboard.GetAllGlobalEntries();

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void GetAllGlobalEntriesCountTest()
        {
            Leaderboard leaderboard = new Leaderboard();

            leaderboard.GetAllGlobalEntries();

            Assert.AreEqual(13, leaderboard.GlobalEntries.Count);
        }

        [TestMethod]
        public void GetPersonalEntriesByUserIDTest()
        {
            Leaderboard leaderboard = new Leaderboard();

            bool actual = leaderboard.GetPersonalEntriesByUserID(0);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void GetPersonalEntriesByUserIDCountTest()
        {
            Leaderboard leaderboard = new Leaderboard();

            leaderboard.GetPersonalEntriesByUserID(0);

            Assert.AreEqual(7, leaderboard.PersonalEntries.Count);
        }
    }
}
