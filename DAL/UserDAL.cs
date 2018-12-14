using System;
using System.Collections.Generic;
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
        /// Returns the user data belonging to the user with the given userID.
        /// </summary>
        /// <param name="userID">The ID to find the user with.</param>
        /// <returns></returns>
        public UserData GetUserDataByID(int userID) { throw new NotImplementedException(); }
    }
}
