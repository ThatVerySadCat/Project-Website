using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicInterfaces
{
    public interface IUserCollection
    {
        /// <summary>
        /// A list of IUser interfaces.
        /// </summary>
        List<IUser> Users { get; set; }
        /// <summary>
        /// A single IUser interface.
        /// </summary>
        IUser SelectedUser { get; set; }

        /// <summary>
        /// Fills the Users property with the data belonging to all users and returns true. Returns false if no users are found.
        /// </summary>
        /// <returns></returns>
        bool GetAllUsers();
        /// <summary>
        /// Sets the SelectedUser property to the user data of the user with the given userID and returns true. Returns false if the user with the given userID could not be found.
        /// </summary>
        /// <param name="userID">The ID to search by.</param>
        /// <returns></returns>
        bool GetUserByID(int userID);
    }
}
