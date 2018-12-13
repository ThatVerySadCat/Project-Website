using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project___Website.Models
{
    public class AccountViewModel
    {
        /// <summary>
        /// A list of enemies whom the requested user has created.
        /// </summary>
        public List<EnemyViewModel> PersonalEnemyList
        {
            get;
            set;
        }
        /// <summary>
        /// A list of leaderboard entries belonging to the requested user.
        /// </summary>
        public List<LeaderboardEntryViewModel> PersonalLeaderboardEntries
        {
            get;
            set;
        }
        /// <summary>
        /// The username of the requested user.
        /// </summary>
        public string Username
        {
            get;
            set;
        }

        public AccountViewModel()
        {
            PersonalEnemyList = new List<EnemyViewModel>();
            PersonalLeaderboardEntries = new List<LeaderboardEntryViewModel> ();
        }
    }
}