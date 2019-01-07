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
        /// The name of the user.
        /// </summary>
        string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Sets the properties to the one of the given userID and returns true. Returns false if the user with the given userID could not be found.
        /// </summary>
        /// <param name="userID">The ID to search by.</param>
        /// <returns></returns>
        bool GetUserByID(int userID);
    }
}
