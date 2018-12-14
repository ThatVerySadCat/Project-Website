using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DALInterfaces;
using Structs;

namespace DAL
{
    public class LeaderboardDAL : BaseDAL, ILeaderboardDAL
    {
        public LeaderboardDAL() : base() { }

        /// <summary>
        /// Returns all score data found in the database.
        /// </summary>
        /// <returns></returns>
        public List<ScoreData> GetAllScoreDatas() { throw new NotImplementedException(); }

        /// <summary>
        /// Returns all score data where the user who achieved it having the given userID.
        /// </summary>
        /// <param name="userID">The ID of the user who achieved the score.</param>
        /// <returns></returns>
        public List<ScoreData> GetScoreDataByUserID(int userID) { throw new NotImplementedException(); }
    }
}
