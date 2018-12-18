using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DALInterfaces;
using Structs;

namespace DAL
{
    public class UserDAL : BaseDAL, IUserDAL
    {
        public UserDAL() : base() { }

        /// <summary>
        /// Attempts to register a new user with the given username and password and returns true. Throws an Exception otherwise.
        /// </summary>
        /// <param name="username">The new users username.</param>
        /// <param name="password">The new users password.</param>
        /// <returns></returns>
        public bool RegisterNewUser(string username, string password)
        {
            WriteQuery("INSERT INTO [User] (Username, Password, ScorePointsCurrency) VALUES ('" + username + "', '" + password + "', 0)");

            return true;
        }

        /// <summary>
        /// Attempts to get all user data and returns it in a list. Throws an Exception otherwise.
        /// </summary>
        /// <returns></returns>
        public List<UserData> GetAllUserDatas()
        {
            DataTable table = ReadQuery("SELECT * FROM [User]");
            List<UserData> returnList = new List<UserData>(table.Rows.Count);
            foreach (DataRow row in table.Rows)
            {
                int id = (int)row["UserID"];
                string name = (string)row["Username"];

                returnList.Add(new UserData(id, name));
            }

            return returnList;
        }

        /// <summary>
        /// Returns the user data belonging to the user with the given userID. Throws an ArgumentException if the user could not be found. Throws an Exception on error.
        /// </summary>
        /// <param name="userID">The ID to find the user with.</param>
        /// <returns></returns>
        public UserData GetUserDataByID(int userID)
        {
            DataTable table = ReadQuery("SELECT * FROM [User] WHERE UserID = " + userID);
            if(table != null && table.Rows.Count > 0)
            {
                string userName = (string)table.Rows[0]["Username"];
                return new UserData(userID, userName);
            }

            throw new ArgumentException("The user with the given ID (" + userID + ") could not be found.");
        }

        /// <summary>
        /// Returns the UserData that belongs to the user with the given username. Throws an ArgumentException if the user could not be found. Throws an Exception on error.
        /// </summary>
        /// <param name="username">The name of the user to find.</param>
        /// <returns></returns>
        public UserData GetUserDataByUsername(string username)
        {
            DataTable table = ReadQuery("SELECT * FROM [User] WHERE Username = '" + username + "'");
            if(table != null && table.Rows.Count > 0)
            {
                int id = (int)table.Rows[0]["UserID"];
                return new UserData(id, username);
            }

            throw new ArgumentException("The user with the given username (" + username + ") could not be found.");
        }

        /// <summary>
        /// Returns the UserData that belongs to the user with the given username and password. Throws an ArgumentException if the user could not be found. Throws an Exception on error.
        /// </summary>
        /// <param name="username">The name of the user to find.</param>
        /// <param name="password">The password of the user to find.</param>
        /// <returns></returns>
        public UserData GetUserDataByUsernameAndPassword(string username, string password)
        {
            DataTable table = ReadQuery("SELECT * FROM [User] WHERE Username = '" + username + "' AND Password = '" + password + "'");
            if(table != null && table.Rows.Count > 0)
            {
                int id = (int)table.Rows[0]["UserID"];
                return new UserData(id, username);
            }

            throw new ArgumentException("The user with the given username (" + username + ") and/or password (" + password + ") could not be found");
        }
    }
}
