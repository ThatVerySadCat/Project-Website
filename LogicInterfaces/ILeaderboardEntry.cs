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
        /// A list of global leaderboard entries.
        /// </summary>
        List<ILeaderboardEntry> GlobalEntries
        {
            get;
            set;
        }
        /// <summary>
        /// A list of leaderboard entries belonging to a specific user.
        /// </summary>
        List<ILeaderboardEntry> PersonalEntries
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

        /// <summary>
        /// Fills the GlobalEntries property with all leaderboard entries and returns true. Returns false if there are no entries.
        /// </summary>
        /// <returns></returns>
        bool GetAllGlobalLeaderboardEntries();
        /// <summary>
        /// Gets the leaderboard entries belonging to the user with the given userID and returns true. Returns false if there are no entries.
        /// </summary>
        /// <param name="userID">The ID of the user whose leaderboard entries to find.</param>
        /// <returns></returns>
        bool GetAllPersonalLeaderboardEntries(int userID);
    }
}
