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
    public class UserCollection : IUserCollection
    {
        /// <summary>
        /// A list of IUser interfaces.
        /// </summary>
        public List<IUser> Users { get; set; }
        /// <summary>
        /// A single IUser interface.
        /// </summary>
        public IUser SelectedUser { get; set; }

        private IUserDAL iUserDAL = UserDALFactory.CreateUserDALInterface();

        /// <summary>
        /// Fills the Users property with the data belonging to all users and returns true. Returns false if no users are found.
        /// </summary>
        /// <returns></returns>
        public bool GetAllUsers()
        {
            try
            {
                List<UserData> userDatas = iUserDAL.GetAllUserDatas();
                if (userDatas != null && userDatas.Count > 0)
                {
                    Users = new List<IUser>(userDatas.Count);
                    foreach (UserData userData in userDatas)
                    {
                        Users.Add(new User(userData.ID, userData.Name));
                    }

                    return true;
                }
            }
            catch (Exception) { }

            return false;
        }

        /// <summary>
        /// Sets the SelectedUser property to the user data of the user with the given userID and returns true. Returns false if the user with the given userID could not be found.
        /// </summary>
        /// <param name="userID">The ID to search by.</param>
        /// <returns></returns>
        public bool GetUserByID(int id)
        {
            try
            {
                UserData userData = iUserDAL.GetUserDataByID(id);
                SelectedUser = new User(userData.ID, userData.Name);

                return true;
            }
            catch (Exception) { }

            return false;
        }
    }
}
