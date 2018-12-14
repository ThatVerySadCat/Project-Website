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
        /// A list of global leaderboard entries.
        /// </summary>
        public List<ILeaderboardEntry> GlobalEntries
        {
            get;
            set;
        }
        /// <summary>
        /// A list of leaderboard entries belonging to a specific user.
        /// </summary>
        public List<ILeaderboardEntry> PersonalEntries
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
        /// THIS CONSTRUCTOR EXISTS FOR TESTING PURPOSES ONLY!
        /// PLEASE REMOVE ASAP!
        /// </summary>
        /// <param name="_score"></param>
        /// <param name="_username"></param>
        public LeaderboardEntry(int _globalPosition, int _id, int _score, string _username)
        {
            GlobalPosition = _globalPosition;
            ID = _id;
            Score = _score;
            Username = _username;
        }

        /// <summary>
        /// Fills the GlobalEntries property with all leaderboard entries and returns true. Returns false if there are no entries.
        /// </summary>
        /// <returns></returns>
        public bool GetAllGlobalLeaderboardEntries()
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
        /// Gets the leaderboard entries belonging to the user with the given userID and returns true. Returns false if there are no entries.
        /// </summary>
        /// <param name="userID">The ID of the user whose leaderboard entries to find.</param>
        /// <returns></returns>
        public bool GetAllPersonalLeaderboardEntries(int userID)
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
