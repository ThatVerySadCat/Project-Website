using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DALFactory;
using DALInterfaces;
using LogicInterfaces;
using Structs;

namespace Logic
{
    public class Account : IAccount
    {
        /// <summary>
        /// The user that was just logged in. Otherwise null.
        /// </summary>
        public IUser LoggedInUser
        {
            get;
            set;
        }
        
        private IUserDAL iUserDAL = UserDALFactory.CreateUserDALInterface();

        /// <summary>
        /// Is the given username available for use?
        /// </summary>
        /// <param name="username">The username to check.</param>
        /// <returns></returns>
        public bool IsUsernameAvailable(string username)
        {
            try
            {
                UserData userData = iUserDAL.GetUserDataByUsername(username);
                return false;
            }
            catch (ArgumentException) { }
            catch (Exception) { }

            // Possible Exception Thingy
            // Make it so that upon ArgumentException it returns false
            // But on Exeption it leads to the user being brought to an error page

            return true;
        }

        /// <summary>
        /// Attempts to log the user in with the given username and password and returns true if succesful. Returns false otherwise.
        /// </summary>
        /// <param name="username">The username to login with.</param>
        /// <param name="password">The password to login with.</param>
        /// <returns></returns>
        public bool Login(string username, string password)
        {
            // Check here if the given username/password are valid by using the DAL
            try
            {
                UserData userData = iUserDAL.GetUserDataByUsernameAndPassword(username, password);
                LoggedInUser = new User(userData.ID, userData.Name);

                return true;
            }
            catch (ArgumentException) { }
            catch (Exception) { }

            return false;
        }

        /// <summary>
        /// TODO: Fill this function.
        /// </summary>
        /// <returns></returns>
        public bool Logout()
        {
            return true;
        }

        /// <summary>
        /// Attempts to register a new user with the given username and password and returns true if succesful. Returns false otherwise.
        /// </summary>
        /// <param name="username">The username to register with.</param>
        /// <param name="password">The password to register with.</param>
        /// <returns></returns>
        public bool Register(string username, string password)
        {
            try
            {
                bool hasRegistered = iUserDAL.RegisterNewUser(username, password);
                return hasRegistered;
            }
            catch (Exception) { }

            return false;
        }
    }
}
