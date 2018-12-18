using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Logic;
using LogicInterfaces;

namespace LogicFactory
{
    public class AccountFactory
    {
        /// <summary>
        /// Returns a new IAccount interface.
        /// </summary>
        /// <returns></returns>
        public static IAccount CreateAccountInterface()
        {
            return new Account();
        }
    }
}
