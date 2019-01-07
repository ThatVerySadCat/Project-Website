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
    }
}
