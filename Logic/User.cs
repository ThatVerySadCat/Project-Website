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
    public class User : IUser
    {
        /// <summary>
        /// The users ID.
        /// </summary>
        public int ID
        {
            get;
            set;
        }
        /// <summary>
        /// The name of the user.
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// The interface to communicate with the DAL.
        /// </summary>
        private IUserDAL iUserDAL = UserDALFactory.CreateUserDALInterface();

        public User() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_id">The users ID.</param>
        /// <param name="_name">The name of the user.</param>
        public User(int _id, string _name)
        {
            ID = _id;
            Name = _name;
        }

        /// <summary>
        /// Sets the properties to the one of the given userID and returns true. Returns false if the user with the given userID could not be found.
        /// </summary>
        /// <param name="userID">The ID to search by.</param>
        /// <returns></returns>
        public bool GetUserByID(int userID)
        {
            try
            {
                UserData userData = iUserDAL.GetUserDataByID(userID);
                ID = userData.ID;
                Name = userData.Name;

                return true;
            }
            catch (Exception) { }

            return false;
        }
    }
}
