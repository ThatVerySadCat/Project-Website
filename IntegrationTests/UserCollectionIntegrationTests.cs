using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Logic;
using LogicInterfaces;

namespace IntegrationTests
{
    [TestClass]
    public class UserCollectionIntegrationTests
    {
        [TestMethod]
        public void GetAllUsersTest()
        {
            UserCollection userCollection = new UserCollection();

            bool actual = userCollection.GetAllUsers();

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void GetAllUsersCountTest()
        {
            UserCollection userCollection = new UserCollection();

            userCollection.GetAllUsers();

            Assert.AreEqual(7, userCollection.Users.Count);
        }
    }
}
