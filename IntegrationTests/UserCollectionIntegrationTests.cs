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

            Assert.AreEqual(5, userCollection.Users.Count);
        }

        [TestMethod]
        public void GetUserByIDTest()
        {
            UserCollection userCollection = new UserCollection();

            bool actual = userCollection.GetUserByID(0);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void GetUserByIDNameTest()
        {
            UserCollection userCollection = new UserCollection();

            userCollection.GetUserByID(0);

            Assert.AreEqual("TestName", userCollection.SelectedUser.Name);
        }
    }
}
