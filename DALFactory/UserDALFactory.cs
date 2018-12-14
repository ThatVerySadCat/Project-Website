using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using DALInterfaces;

namespace DALFactory
{
    public class UserDALFactory
    {
        /// <summary>
        /// Returns a new User DAL interface.
        /// </summary>
        /// <returns></returns>
        public static IUserDAL CreateUserDALInterface()
        {
            return new UserDAL();
        }
    }
}
