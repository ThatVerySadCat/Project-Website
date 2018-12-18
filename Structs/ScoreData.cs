using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    public struct ScoreData
    {
        /// <summary>
        /// The position of the entry on the global leaderboard.
        /// </summary>
        public int Position
        {
            get;
            private set;
        }
        /// <summary>
        /// The amount of score obtained.
        /// </summary>
        public int Score
        {
            get;
            private set;
        }
        /// <summary>
        /// The ID of the user who made the entry.
        /// </summary>
        public int UserID
        {
            get;
            private set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_position">The position of the entry on the global leaderboard.</param>
        /// <param name="_score">The amount of score obtained.</param>
        /// <param name="_userID">The ID of the user who made the entry.</param>
        public ScoreData(int _position, int _score, int _userID)
        {
            Position = _position;
            Score = _score;
            UserID = _userID;
        }
    }
}
