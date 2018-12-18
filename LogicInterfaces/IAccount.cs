using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicInterfaces
{
    public interface IAccount
    {
        /// <summary>
        /// The user that was just logged in. Otherwise null.
        /// </summary>
        IUser LoggedInUser { get; set; }

        /// <summary>
        /// Is the given username available for use?
        /// </summary>
        /// <param name="username">The username to check.</param>
        /// <returns></returns>
        bool IsUsernameAvailable(string username);
        /// <summary>
        /// Attempts to log the user in with the given username and password and returns true if succesful. Returns false otherwise.
        /// </summary>
        /// <param name="username">The username to login with.</param>
        /// <param name="password">The password to login with.</param>
        /// <returns></returns>
        bool Login(string username, string password);
        /// <summary>
        /// TODO: Fill this function.
        /// </summary>
        /// <returns></returns>
        bool Logout();
        /// <summary>
        /// Attempts to register a new user with the given username and password and returns true if succesful. Returns false otherwise.
        /// </summary>
        /// <param name="username">The username to register with.</param>
        /// <param name="password">The password to register with.</param>
        /// <returns></returns>
        bool Register(string username, string password);
    }
}
