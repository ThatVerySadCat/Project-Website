using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    public struct UserData
    {
        /// <summary>
        /// The ID belonging to the user.
        /// </summary>
        public int ID
        {
            get;
            private set;
        }
        /// <summary>
        /// The name of the user.
        /// </summary>
        public string Name
        {
            get;
            private set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_id">The ID belonging to the user.</param>
        /// <param name="_name">The name of the user.</param>
        public UserData(int _id, string _name)
        {
            ID = _id;
            Name = _name;
        }
    }
}
