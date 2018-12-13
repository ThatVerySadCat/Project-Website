using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project___Website.Models
{
    public class AccountViewModel
    {
        public List<EnemyViewModel> PersonalEnemyList
        {
            get;
            set;
        }
        public List<LeaderboardEntryViewModel> PersonalLeaderboardEntries
        {
            get;
            set;
        }
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