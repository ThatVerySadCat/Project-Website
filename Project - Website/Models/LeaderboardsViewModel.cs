using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using LogicInterfaces;

namespace Project___Website.Models
{
    public class LeaderboardsViewModel
    {
        public List<ILeaderboardEntry> GlobalLeaderboardEntries { get; set; }
        public List<ILeaderboardEntry> PersonalLeaderboardEntries { get; set; }
    }
}