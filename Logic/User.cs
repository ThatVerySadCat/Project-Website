using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LogicInterfaces;

namespace Logic
{
    public class User : IUser
    {
        // HARD CODED VALUES HERE! TO BE REPLACED LATER!
        private static User hardCodedUser1 = new User(0, "TestName");
        private static User hardCodedUser2 = new User(1, "AppleMan");
        private static User hardCodedUser3 = new User(2, "EAPFan69");
        private static User hardCodedUser4 = new User(3, "Faker");

        private const int hardCodedID = 0;
        private const string hardCodedUsername = "TestName";
        private const string hardCodedPassword = "TestPass";
        // HARD CODED VALUES HERE! TO BE REPLACED LATER!

        /// <summary>
        /// The users ID.
        /// </summary>
        public int ID
        {
            get;
            set;
        }
        /// <summary>
        /// A currently selected user.
        /// </summary>
        public IUser SelectedUser
        {
            get;
            set;
        }
        /// <summary>
        /// A list of users.
        /// </summary>
        public List<IUser> Users
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

        public User()
        {
            ID = -1;
            Users = new List<IUser>();
            Name = "";
        }

        /// <summary>
        /// This is a temporary constructor for testing purposes only.
        /// REMOVE ASAP!
        /// </summary>
        /// <param name="_id"></param>
        /// <param name="_name"></param>
        public User(int _id, string _name)
        {
            ID = _id;
            Users = new List<IUser>();
            Name = _name;
        }

        /// <summary>
        /// Fills the Users property with all users and then returns true. Returns false if no users could be found.
        /// </summary>
        /// <returns></returns>
        public bool GetAllUsers()
        {
            // Get all user data from the DAL here and put it in the Users list
            Users = new List<IUser>(3);
            Users.Add(hardCodedUser1);
            Users.Add(hardCodedUser2);
            Users.Add(hardCodedUser3);
            Users.Add(hardCodedUser4);

            return true;
        }

        /// <summary>
        /// Sets the SelectedUser property to the user with the given id and return true. Returns false if the user could not be found.
        /// </summary>
        /// <param name="id">The ID of the user to find.</param>
        /// <returns></returns>
        public bool GetUserDataByID(int id)
        {
            if(hardCodedUser1.ID == id)
            {
                SelectedUser = new User(hardCodedUser1.ID, hardCodedUser1.Name);

                return true;
            }
            else if(hardCodedUser2.ID == id)
            {
                SelectedUser = new User(hardCodedUser2.ID, hardCodedUser2.Name);

                return true;
            }
            else if(hardCodedUser3.ID == id)
            {
                SelectedUser = new User(hardCodedUser3.ID, hardCodedUser3.Name);

                return true;
            }
            else if(hardCodedUser4.ID == id)
            {
                SelectedUser = new User(hardCodedUser4.ID, hardCodedUser4.Name);

                return true;
            }

            return false;
        }

        /// <summary>
        /// Returns true if the given username is available. Returns false if an user with the given username already exists.
        /// </summary>
        /// <param name="username">The username to check.</param>
        /// <returns></returns>
        public bool IsUsernameAvailable(string username)
        {
            // Check if the given username is already taken in the database
            if(username == hardCodedUser1.Name || username == hardCodedUser2.Name || username == hardCodedUser3.Name || username == hardCodedUser4.Name)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Attempts to log the user in with the given username and password and returns true if succesfull. Returns false otherwise.
        /// </summary>
        /// <param name="username">The username to login with.</param>
        /// <param name="password">The password to login with.</param>
        /// <returns></returns>
        public bool Login(string username, string password)
        {
            // Check here if the given username/password are valid by using the DAL
            if(username == hardCodedUsername && password == hardCodedPassword)
            {
                ID = hardCodedID;
                Name = hardCodedUsername;

                return true;
            }

            return false;
        }

        /// <summary>
        /// Logs the user out.
        /// </summary>
        /// <returns></returns>
        public bool Logout()
        {
            ID = -1;
            Name = "";

            return true;
        }

        /// <summary>
        /// Attempts to register a new account using the given username and password and returns true. Returns false if not succesfull.
        /// </summary>
        /// <param name="username">The username to create the account with.</param>
        /// <param name="password">The password to create the account with.</param>
        /// <returns></returns>
        public bool Register(string username, string password)
        {
            if(username != hardCodedUser1.Name && username != hardCodedUser2.Name && username != hardCodedUser3.Name && username != hardCodedUser4.Name)
            {
                return true;
            }

            return false;
        }
    }
}
