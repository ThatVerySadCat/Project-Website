using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Structs;

namespace DALInterfaces
{
    public interface ILeaderboardDAL
    {
        /// <summary>
        /// Returns all score data found in the database. Throws a NullReferenceException if no scores could be found. Throws an Exception on error.
        /// </summary>
        /// <returns></returns>
        List<ScoreData> GetAllScoreDatas();
        /// <summary>
        /// Returns all score data where the user who achieved it having the given userID. Throws an ArgumentException if the user could not be found. Throws an Exception on Error.
        /// </summary>
        /// <param name="userID">The ID of the user who achieved the score.</param>
        /// <returns></returns>
        List<ScoreData> GetScoreDataByUserID(int userID);
    }
}
