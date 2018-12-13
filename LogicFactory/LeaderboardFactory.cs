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
        /// Creates a new LeaderboardEntry object using the given parameters and returns it as an interface.
        /// </summary>
        /// <param name="position">The position of the entry on the global leaderboard.</param>
        /// <param name="score">The score ascociated with the entry.</param>
        /// <param name="username">The name of the user that made the entry.</param>
        /// <returns></returns>
        public static ILeaderboardEntry CreateLeaderboardEntry(int position, int score, string username)
        {
            return new LeaderboardEntry(position, score, username);
        }
    }
}
