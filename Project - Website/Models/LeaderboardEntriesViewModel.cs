using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using LogicInterfaces;

namespace Project___Website.Models
{
    public class LeaderboardEntriesViewModel
    {
        public List<ILeaderboardEntry> GlobalLeaderboardEntries
        {

            get;
            set;
        }
        public List<ILeaderboardEntry> LeaderboardEntries
        {
            get;
            set;
        }
        public List<ILeaderboardEntry> PersonalLeaderboardEntries
        {
            get;
            set;
        }

        public LeaderboardEntriesViewModel()
        {
            GlobalLeaderboardEntries = new List<ILeaderboardEntry>();
            LeaderboardEntries = new List<ILeaderboardEntry>();
            PersonalLeaderboardEntries = new List<ILeaderboardEntry>();
        }
    }
}