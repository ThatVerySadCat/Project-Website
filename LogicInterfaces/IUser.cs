using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicInterfaces
{
    public interface IUser
    {
        /// <summary>
        /// The users ID.
        /// </summary>
        int ID
        {
            get;
            set;
        }
        /// <summary>
        /// A currently selected user.
        /// </summary>
        IUser SelectedUser
        {
            get;
            set;
        }
        /// <summary>
        /// A list of users.
        /// </summary>
        List<IUser> Users
        {
            get;
            set;
        }
        /// <summary>
        /// The name of the user.
        /// </summary>
        string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Fills the Users property with all users and then returns true. Returns false if no users could be found.
        /// </summary>
        /// <returns></returns>
        bool GetAllUsers();
        /// <summary>
        /// Sets the SelectedUser property to the user with the given id and return true. Returns false if the user could not be found.
        /// </summary>
        /// <param name="id">The ID of the user to find.</param>
        /// <returns></returns>
        bool GetUserDataByID(int id);
        /// <summary>
        /// Returns true if the given username is available. Returns false if an user with the given username already exists.
        /// </summary>
        /// <param name="username">The username to check.</param>
        /// <returns></returns>
        bool IsUsernameAvailable(string username);
        /// <summary>
        /// Attempts to log the user in with the given username and password and returns true if succesfull. Returns false otherwise.
        /// </summary>
        /// <param name="username">The username to login with.</param>
        /// <param name="password">The password to login with.</param>
        /// <returns></returns>
        bool Login(string username, string password);
        /// <summary>
        /// Logs the user out.
        /// </summary>
        /// <returns></returns>
        bool Logout();
        /// <summary>
        /// Attempts to register a new account using the given username and password and returns true. Returns false if not succesfull.
        /// </summary>
        /// <param name="username">The username to create the account with.</param>
        /// <param name="password">The password to create the account with.</param>
        /// <returns></returns>
        bool Register(string username, string password);
    }
}
