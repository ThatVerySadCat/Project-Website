using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LogicInterfaces;

namespace Logic
{
    public class Leaderboard : ILeaderboard
    {
        // HARD CODED DATA! PLEASE REMOVE ASAP!
        private static LeaderboardEntry[] hardCodedEntries = new LeaderboardEntry[] {
            new LeaderboardEntry(1, 0, 100, "TestName"),
            new LeaderboardEntry(2, 0, 50, "TestName"),
            new LeaderboardEntry(3, 0, 25, "TestName"),
            new LeaderboardEntry(4, 1, 20, "AppleMan"),
            new LeaderboardEntry(5, 1, 15, "AppleMan"),
            new LeaderboardEntry(6, 1, 10, "AppleMan"),
            new LeaderboardEntry(7, 2, 9, "EAPFan69"),
            new LeaderboardEntry(8, 0, 5, "TestName"),
            new LeaderboardEntry(9, 0, 4, "TestName"),
            new LeaderboardEntry(10, 0, 3, "TestName"),
            new LeaderboardEntry(11, 0, 2, "TestName") };
        // HARD CODED DATA! PLEASE REMOVE ASAP!

        /// <summary>
        /// Global leaderboard entries.
        /// </summary>
        public List<ILeaderboardEntry> GlobalEntries { get; set; }
        /// <summary>
        /// Leaderboard entries that are specific to a single user.
        /// </summary>
        public List<ILeaderboardEntry> PersonalEntries { get; set; }

        /// <summary>
        /// Fills the GlobalEntries property with all of the existing leaderboard entries and returns true. Returns false if no entries could be found.
        /// </summary>
        /// <returns></returns>
        public bool GetAllGlobalEntries()
        {
            if (hardCodedEntries.Length > 0)
            {
                GlobalEntries = new List<ILeaderboardEntry>();
                GlobalEntries.AddRange(hardCodedEntries);

                return true;
            }

            return false;
        }

        /// <summary>
        /// Fills the PersonalEntries property with all of the leaderboard entries specific to the user with the given userID and returns true. Returns false if no entries could be found.
        /// </summary>
        /// <param name="userID">The ID to search by.</param>
        /// <returns></returns>
        public bool GetPersonalEntriesByUserID(int userID)
        {
            if (hardCodedEntries.Length > 0)
            {
                PersonalEntries = hardCodedEntries.Where(leaderboardEntry => leaderboardEntry.ID == userID).ToList<ILeaderboardEntry>();

                return true;
            }

            return false;
        }
    }
}
