using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using LogicInterfaces;

namespace Project___Website.Models
{
    public class StatsViewModel
    {
        public List<int> EnemyCountsPerDifficulty { get; set; }
        public List<int> EnemyCountsPerUser { get; set; }
    }
}