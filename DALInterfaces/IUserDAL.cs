using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Structs;

namespace DALInterfaces
{
    public interface IUserDAL
    {
        /// <summary>
        /// Attempts to register a new user with the given username and password and returns true. Throws an Exception otherwise.
        /// </summary>
        /// <param name="username">The new users username.</param>
        /// <param name="password">The new users password.</param>
        /// <returns></returns>
        bool RegisterNewUser(string username, string password);
        /// <summary>
        /// Attempts to get all user data and returns it in a list. Throws an Exception otherwise.
        /// </summary>
        /// <returns></returns>
        List<UserData> GetAllUserDatas();
        /// <summary>
        /// Returns the user data belonging to the user with the given userID. Throws an ArgumentException if the user could not be found. Throws an Exception on error.
        /// </summary>
        /// <param name="userID">The ID to find the user with.</param>
        /// <returns></returns>
        UserData GetUserDataByID(int userID);
        /// <summary>
        /// Returns the UserData that belongs to the user with the given username. Throws an ArgumentException if the user could not be found. Throws an Exception on error.
        /// </summary>
        /// <param name="username">The name of the user to find.</param>
        /// <returns></returns>
        UserData GetUserDataByUsername(string username);
        /// <summary>
        /// Returns the UserData that belongs to the user with the given username and password. Throws an ArgumentException if the user could not be found. Throws an Exception on error.
        /// </summary>
        /// <param name="username">The name of the user to find.</param>
        /// <param name="password">The password of the user to find.</param>
        /// <returns></returns>
        UserData GetUserDataByUsernameAndPassword(string username, string password);
    }
}
