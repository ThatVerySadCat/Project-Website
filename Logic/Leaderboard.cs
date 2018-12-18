using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DALFactory;
using DALInterfaces;
using LogicInterfaces;

using Structs;

namespace Logic
{
    public class Leaderboard : ILeaderboard
    {
        /// <summary>
        /// Global leaderboard entries.
        /// </summary>
        public List<ILeaderboardEntry> GlobalEntries { get; set; }
        /// <summary>
        /// Leaderboard entries that are specific to a single user.
        /// </summary>
        public List<ILeaderboardEntry> PersonalEntries { get; set; }

        private ILeaderboardDAL iLeaderboardDAL = LeaderboardDALFactory.CreateLeaderboardDALInterface();
        private IUserDAL iUserDAL = UserDALFactory.CreateUserDALInterface();

        /// <summary>
        /// Fills the GlobalEntries property with all of the existing leaderboard entries and returns true. Returns false if no entries could be found.
        /// </summary>
        /// <returns></returns>
        public bool GetAllGlobalEntries()
        {
            try
            {
                List<ScoreData> scoreDatas = iLeaderboardDAL.GetAllScoreDatas();
                GlobalEntries = new List<ILeaderboardEntry>(scoreDatas.Count);
                foreach(ScoreData scoreData in scoreDatas)
                {
                    try
                    {
                        UserData userData = iUserDAL.GetUserDataByID(scoreData.UserID);
                        GlobalEntries.Add(new LeaderboardEntry(scoreData.Position, scoreData.UserID, scoreData.Score, userData.Name));
                    }
                    catch (Exception) { }
                }

                return true;
            }
            catch (Exception) { }

            return false;
        }

        /// <summary>
        /// Fills the PersonalEntries property with all of the leaderboard entries specific to the user with the given userID and returns true. Returns false if no entries could be found.
        /// </summary>
        /// <param name="userID">The ID to search by.</param>
        /// <returns></returns>
        public bool GetPersonalEntriesByUserID(int userID)
        {
            try
            {
                List<ScoreData> scoreDatas = iLeaderboardDAL.GetScoreDataByUserID(userID);
                PersonalEntries = new List<ILeaderboardEntry>(scoreDatas.Count);
                foreach (ScoreData scoreData in scoreDatas)
                {
                    try
                    {
                        UserData userData = iUserDAL.GetUserDataByID(userID);
                        PersonalEntries.Add(new LeaderboardEntry(scoreData.Position, scoreData.UserID, scoreData.Score, userData.Name));
                    }
                    catch (Exception) { }
                }

                return true;
            }
            catch (Exception) { }

            return false;
        }
    }
}
