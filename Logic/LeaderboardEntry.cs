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
        private static LeaderboardEntry hardCodedEntry1 = new LeaderboardEntry(1, 0, 100, "TestName");
        private static LeaderboardEntry hardCodedEntry2 = new LeaderboardEntry(2, 0, 50, "TestName");
        private static LeaderboardEntry hardCodedEntry3 = new LeaderboardEntry(3, 0, 25, "TestName");
        private static LeaderboardEntry hardCodedEntry4 = new LeaderboardEntry(4, 0, 12, "TestName");
        private static LeaderboardEntry hardCodedEntry5 = new LeaderboardEntry(5, 0, 11, "TestName");
        private static LeaderboardEntry hardCodedEntry6 = new LeaderboardEntry(6, 0, 10, "TestName");
        private static LeaderboardEntry hardCodedEntry7 = new LeaderboardEntry(7, 0, 9, "TestName");

        private static LeaderboardEntry hardCodedEntry8 = new LeaderboardEntry(8, 1, 8, "AppleMan");
        private static LeaderboardEntry hardCodedEntry9 = new LeaderboardEntry(9, 1, 4, "AppleMan");
        private static LeaderboardEntry hardCodedEntry10 = new LeaderboardEntry(10, 1, 2, "AppleMan");

        private static LeaderboardEntry hardCodedEntry11 = new LeaderboardEntry(11, 2, 1, "EAPFan69");
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
        /// Gets the leaderboard entries belonging to the user with the given userID and returns true. Returns false if there are no entries.
        /// </summary>
        /// <param name="userID">The ID of the user whose leaderboard entries to find.</param>
        /// <returns></returns>
        public bool GetLeaderboardEntriesByUserID(int userID)
        {
            if(hardCodedEntry1.ID == userID)
            {
                PersonalEntries = new List<ILeaderboardEntry>(7);
                PersonalEntries.Add(hardCodedEntry1);
                PersonalEntries.Add(hardCodedEntry2);
                PersonalEntries.Add(hardCodedEntry3);
                PersonalEntries.Add(hardCodedEntry4);
                PersonalEntries.Add(hardCodedEntry5);
                PersonalEntries.Add(hardCodedEntry6);
                PersonalEntries.Add(hardCodedEntry7);

                return true;
            }
            else if(hardCodedEntry8.ID == userID)
            {
                PersonalEntries = new List<ILeaderboardEntry>(3);
                PersonalEntries.Add(hardCodedEntry8);
                PersonalEntries.Add(hardCodedEntry9);
                PersonalEntries.Add(hardCodedEntry10);

                return true;
            }
            else if(hardCodedEntry11.ID == userID)
            {
                PersonalEntries = new List<ILeaderboardEntry>(1);
                PersonalEntries.Add(hardCodedEntry11);

                return true;
            }

            return false;
        }
    }
}
