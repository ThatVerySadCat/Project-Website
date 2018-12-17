using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Logic;
using LogicInterfaces;

namespace LogicFactory
{
    public class UserCollectionFactory
    {
        /// <summary>
        /// Returns a new IUserCollection interface.
        /// </summary>
        /// <returns></returns>
        public static IUserCollection CreateUserCollectionInterface()
        {
            return new UserCollection();
        }
    }
}
