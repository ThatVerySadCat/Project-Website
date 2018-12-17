using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Logic;
using LogicInterfaces;

namespace LogicFactory
{
    public class LeaderboardFactory
    {
        /// <summary>
        /// Returns a new ILeaderboard interface.
        /// </summary>
        /// <returns></returns>
        public static ILeaderboard CreateLeaderboardInterface()
        {
            return new Leaderboard();
        }
    }
}
