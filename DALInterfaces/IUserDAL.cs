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
        /// Returns the user data belonging to the user with the given userID.
        /// </summary>
        /// <param name="userID">The ID to find the user with.</param>
        /// <returns></returns>
        UserData GetUserDataByID(int userID);
    }
}
