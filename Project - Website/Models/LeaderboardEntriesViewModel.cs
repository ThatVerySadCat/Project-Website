using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project___Website.Models
{
    public class LeaderboardEntriesViewModel
    {
        /// <summary>
        /// A list containing the global leaderboard entries.
        /// </summary>
        public List<LeaderboardEntryViewModel> GlobalLeaderboardEntries
        {

            get;
            set;
        }
        /// <summary>
        /// A list containing the personal leaderboard entries.
        /// </summary>
        public List<LeaderboardEntryViewModel> PersonalLeaderboardEntries
        {
            get;
            set;
        }

        public LeaderboardEntriesViewModel()
        {
            GlobalLeaderboardEntries = new List<LeaderboardEntryViewModel>();
            PersonalLeaderboardEntries = new List<LeaderboardEntryViewModel>();
        }
    }
}