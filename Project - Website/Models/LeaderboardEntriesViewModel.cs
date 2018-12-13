using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using LogicInterfaces;

namespace Project___Website.Models
{
    public class LeaderboardEntriesViewModel
    {
        /// <summary>
        /// A list containing the global leaderboard entries.
        /// </summary>
        public List<ILeaderboardEntry> GlobalLeaderboardEntries
        {

            get;
            set;
        }
        /// <summary>
        /// A list containing the personal leaderboard entries.
        /// </summary>
        public List<ILeaderboardEntry> PersonalLeaderboardEntries
        {
            get;
            set;
        }

        public LeaderboardEntriesViewModel()
        {
            GlobalLeaderboardEntries = new List<ILeaderboardEntry>();
            PersonalLeaderboardEntries = new List<ILeaderboardEntry>();
        }
    }
}