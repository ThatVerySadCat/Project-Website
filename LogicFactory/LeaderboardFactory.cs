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
        public static ILeaderboardEntry CreateLeaderboardEntry(int position, int score, string username)
        {
            return new LeaderboardEntry(position, score, username);
        }
    }
}
