using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Logic;

namespace IntegrationTests
{
    [TestClass]
    public class AccountIntegrationTests
    {
        [TestMethod]
        public void IsUsernameAvailableTestSuccess()
        {
            Account account = new Account();

            bool actual = account.IsUsernameAvailable("FreeName");

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void IsUsernameAvailableTestFailure()
        {
            Account account = new Account();

            bool actual = account.IsUsernameAvailable("TestName");

            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void LoginTestSuccess()
        {
            Account account = new Account();

            bool actual = account.Login("TestName", "TestPass");

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void LoginTestFailure()
        {
            Account account = new Account();

            bool actual = account.Login("FalseUsername", "FalsePassword");

            Assert.AreEqual(false, actual);
        }
    }
}
