using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicInterfaces
{
    public interface ILeaderboard
    {
        /// <summary>
        /// Global leaderboard entries.
        /// </summary>
        List<ILeaderboardEntry> GlobalEntries { get; set; }
        /// <summary>
        /// Leaderboard entries that are specific to a single user.
        /// </summary>
        List<ILeaderboardEntry> PersonalEntries { get; set; }

        /// <summary>
        /// Fills the GlobalEntries property with all of the existing leaderboard entries and returns true. Returns false if no entries could be found.
        /// </summary>
        /// <returns></returns>
        bool GetAllGlobalEntries();
        /// <summary>
        /// Fills the PersonalEntries property with all of the leaderboard entries specific to the user with the given userID and returns true. Returns false if no entries could be found.
        /// </summary>
        /// <param name="userID">The ID to search by.</param>
        /// <returns></returns>
        bool GetPersonalEntriesByUserID(int userID);
    }
}
