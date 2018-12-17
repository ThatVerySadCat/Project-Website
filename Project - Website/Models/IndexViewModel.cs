using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using LogicInterfaces;

namespace Project___Website.Models
{
    public class IndexViewModel
    {
        /// <summary>
        /// A list of global leaderboard entries.
        /// </summary>
        public List<ILeaderboardEntry> GlobalLeaderboardEntries { get; set; }
        /// <summary>
        /// A list of personal leaderboard entries.
        /// </summary>
        public List<ILeaderboardEntry> PersonalLeaderboardEntries { get; set; }
    }
}