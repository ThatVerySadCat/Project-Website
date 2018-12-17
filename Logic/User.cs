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
        private static User[] hardCodedUsers = new User[] {
         new User(0, "TestName", "TestPass"),
         new User(1, "AppleMan", "ApplePass"),
         new User(2, "EAPFan69", "EAPPass"),
         new User(3, "Faker", "FakerPass") };
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
        /// The name of the user.
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// This is a temporary value to store the password for a user.
        /// DO NOT USE THIS WHEN ACTUALLY WORKING WITH PASSWORDS AS IT IS NOT NECESARY!
        /// </summary>
        private string password = "";

        public User()
        {
            ID = -1;
            Name = "";
        }

        /// <summary>
        /// This is a temporary constructor for testing purposes only.
        /// REMOVE ASAP!
        /// </summary>
        /// <param name="_id"></param>
        /// <param name="_name"></param>
        /// <param name="_password"></param>
        public User(int _id, string _name, string _password)
        {
            ID = _id;
            Name = _name;

            password = _password;
        }

        /// <summary>
        /// Returns true if the given username is available. Returns false if an user with the given username already exists.
        /// </summary>
        /// <param name="username">The username to check.</param>
        /// <returns></returns>
        public bool IsUsernameAvailable(string username)
        {
            // Check if the given username is already taken in the database
            bool usernameUnique = hardCodedUsers.Where(user => user.Name == username).Count() == 0;
            if(usernameUnique)
            {
                return true;
            }

            return false;
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
            IUser loggedInUser = hardCodedUsers.Where(user => user.Name == username && user.password == password).FirstOrDefault();
            if(loggedInUser != null)
            {
                ID = loggedInUser.ID;
                Name = loggedInUser.Name;

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
            IUser iUser = hardCodedUsers.Where(user => user.Name == username).FirstOrDefault();
            if(iUser == null)
            {
                return true;
            }

            return false;
        }
    }
}
