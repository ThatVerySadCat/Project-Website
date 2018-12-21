using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using DAL;
using Structs;

namespace UnitTests
{
    [TestClass]
    public class UserDALTests
    {
        [TestMethod]
        public void GetUserDataByUsernameAndPasswordTest()
        {
            UserDAL userDAL = new UserDAL();

            UserData userData = userDAL.GetUserDataByUsernameAndPassword("TestName", "TestPass");

            Assert.AreEqual("TestName", userData.Name);
        }
    }
}
