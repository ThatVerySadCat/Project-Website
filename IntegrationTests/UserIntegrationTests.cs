using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Logic;

namespace IntegrationTests
{
    [TestClass]
    public class UserIntegrationTests
    {
        [TestMethod]
        public void GetUserByIDTest()
        {
            User user = new User();

            bool actual = user.GetUserByID(0);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void GetUserByIDNameTest()
        {
            User user = new User();

            user.GetUserByID(0);

            Assert.AreEqual("TestName", user.Name);
        }
    }
}
