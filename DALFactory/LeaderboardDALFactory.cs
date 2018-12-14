using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using DALInterfaces;

namespace DALFactory
{
    public class LeaderboardDALFactory
    {
        /// <summary>
        /// Returns a new ILeaderboardDAL interface.
        /// </summary>
        /// <returns></returns>
        public static ILeaderboardDAL CreateLeaderboardDALInterface()
        {
            return new LeaderboardDAL();
        }
    }
}
