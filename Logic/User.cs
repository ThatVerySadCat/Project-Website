using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DALFactory;
using DALInterfaces;
using LogicInterfaces;

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
    }
}
