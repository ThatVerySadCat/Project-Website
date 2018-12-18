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
    }
}
