using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicInterfaces
{
    public interface ILeaderboardEntry
    {
        /// <summary>
        /// The position of the entry on the global leaderboard.
        /// </summary>
        int Position
        {
            get;
            set;
        }
        /// <summary>
        /// The score ascociated with the entry.
        /// </summary>
        int Score
        {
            get;
            set;
        }
        /// <summary>
        /// The name of the user that made the entry.
        /// </summary>
        string Username
        {
            get;
            set;
        }
    }
}
