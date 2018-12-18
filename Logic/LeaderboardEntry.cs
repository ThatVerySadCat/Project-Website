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
        public int GlobalPosition
        {
            get;
            set;
        }
        /// <summary>
        /// The ID of the user that made the entry.
        /// </summary>
        public int ID
        {
            get;
            set;
        }
        /// <summary>
        /// The score that is ascociated with the entry.
        /// </summary>
        public int Score
        {
            get;
            set;
        }
        /// <summary>
        /// The username of the user that made the entry.
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
        /// <param name="_globalPosition">The position of the entry on the global leaderboard.</param>
        /// <param name="_id">The ID of the user that made the entry.</param>
        /// <param name="_score">The score that is ascociated with the entry.</param>
        /// <param name="_username">The name of the user that made the entry.</param>
        public LeaderboardEntry(int _globalPosition, int _id, int _score, string _username)
        {
            GlobalPosition = _globalPosition;
            ID = _id;
            Score = _score;
            Username = _username;
        }
    }
}
