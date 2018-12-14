using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Logic;
using LogicInterfaces;

namespace LogicFactory
{
    public class UserFactory
    {
        /// <summary>
        /// Returns a new IUser interface.
        /// </summary>
        /// <returns></returns>
        public static IUser CreateUserInterface()
        {
            return new User();
        }
    }
}
