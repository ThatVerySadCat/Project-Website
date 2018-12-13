using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LogicInterfaces;

namespace Logic
{
    public class LeaderboardEntry : ILeaderboardEntry
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
        /// The name of the user that made the entry.
        /// </summary>
        public string Username
        {
            get;
            set;
        }

        public LeaderboardEntry() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_position">The position of the entry on the global leaderboard.</param>
        /// <param name="_score">The score ascociated with the entry.</param>
        /// <param name="_username">The name of the user that made the entry.</param>
        public LeaderboardEntry(int _position, int _score, string _username)
        {
            Position = _position;
            Score = _score;
            Username = _username;
        }
    }
}
