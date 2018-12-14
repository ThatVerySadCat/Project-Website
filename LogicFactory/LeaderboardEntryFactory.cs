using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Logic;
using LogicInterfaces;

namespace LogicFactory
{
    public class LeaderboardEntryFactory
    {
        /// <summary>
        /// Returns a new ILeaderboardEntry interface.
        /// </summary>
        /// <returns></returns>
        public static ILeaderboardEntry CreateLeaderboardInterface()
        {
            return new LeaderboardEntry();
        }
    }
}
