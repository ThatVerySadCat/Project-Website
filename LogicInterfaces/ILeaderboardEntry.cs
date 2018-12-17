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
        int GlobalPosition
        {
            get;
            set;
        }
        /// <summary>
        /// The ID of the user that made the entry.
        /// </summary>
        int ID
        {
            get;
            set;
        }
        /// <summary>
        /// The score that is ascociated with the entry.
        /// </summary>
        int Score
        {
            get;
            set;
        }
        /// <summary>
        /// The username of the user that made the entry.
        /// </summary>
        string Username
        {
            get;
            set;
        }
    }
}
