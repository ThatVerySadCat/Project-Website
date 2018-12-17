using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using LogicInterfaces;

namespace Project___Website.Models
{
    public class AccountInfoViewModel
    {
        public IUser User;
        public List<IEnemy> PersonalEnemies;
        public List<ILeaderboardEntry> PersonalLeaderboardEntries;
    }
}