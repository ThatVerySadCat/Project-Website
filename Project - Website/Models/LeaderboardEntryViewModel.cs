using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project___Website.Models
{
    public class LeaderboardEntryViewModel
    {
        /// <summary>
        /// The position of the entry on the global leaderboard.
        /// </summary>
        public int Position
        {
            get;
            set;
        }
        /// <summary>
        /// The score ascociated with the entry.
        /// </summary>
        public int Score
        {
            get;
            set;
        }
        /// <summary>
        /// The name of the user who made the entry.
        /// </summary>
        public string Username
        {
            get;
            set;
        }

        public LeaderboardEntryViewModel() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_position">The position of the entry on the global leaderboard.</param>
        /// <param name="_score">The score ascociated with the entry.</param>
        /// <param name="_username">The name of the user who made the entry.</param>
        public LeaderboardEntryViewModel(int _position, int _score, string _username)
        {
            Position = _position;
            Score = _score;
            Username = _username;
        }
    }
}