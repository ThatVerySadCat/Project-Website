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
        /// The name of the user who achieved the score.
        /// </summary>
        public string Username
        {
            get;
            private set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_position">The position of the entry on the global leaderboard.</param>
        /// <param name="_score">The amount of score obtained.</param>
        /// <param name="_username">The name of the user who achieved the score.</param>
        public ScoreData(int _position, int _score, string _username)
        {
            Position = _position;
            Score = _score;
            Username = _username;
        }
    }
}
