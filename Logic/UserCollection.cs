using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LogicInterfaces;

namespace Logic
{
    public class UserCollection : IUserCollection
    {
        // HARD CODED VALUES HERE! TO BE REPLACED LATER!
        private static User[] hardCodedUsers = new User[] {
         new User(0, "TestName", "TestPass"),
         new User(1, "AppleMan", "ApplePass"),
         new User(2, "EAPFan69", "EAPPass"),
         new User(3, "Faker", "FakerPass") };
        // HARD CODED VALUES HERE! TO BE REPLACED LATER!

        /// <summary>
        /// A list of IUser interfaces.
        /// </summary>
        public List<IUser> Users { get; set; }
        /// <summary>
        /// A single IUser interface.
        /// </summary>
        public IUser SelectedUser { get; set; }

        /// <summary>
        /// Fills the Users property with the data belonging to all users and returns true. Returns false if no users are found.
        /// </summary>
        /// <returns></returns>
        public bool GetAllUsers()
        {
            // Get all user data from the DAL here and put it in the Users list
            if (hardCodedUsers.Length > 0)
            {
                Users = new List<IUser>(3);
                Users.AddRange(hardCodedUsers);

                return true;
            }

            return false;
        }

        /// <summary>
        /// Sets the SelectedUser property to the user data of the user with the given userID and returns true. Returns false if the user with the given userID could not be found.
        /// </summary>
        /// <param name="userID">The ID to search by.</param>
        /// <returns></returns>
        public bool GetUserByID(int id)
        {
            IUser iUser = hardCodedUsers.Where(user => user.ID == id).FirstOrDefault();
            if (iUser != null)
            {
                SelectedUser = iUser;

                return true;
            }

            return false;
        }
    }
}
