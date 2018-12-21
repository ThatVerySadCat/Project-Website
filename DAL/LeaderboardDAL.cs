using System;
using System.Collections.Generic;
using System.Data;
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
        /// Returns all score data found in the database. Throws a NullReferenceException if no scores could be found. Throws an Exception on error.
        /// </summary>
        /// <returns></returns>
        public List<ScoreData> GetAllScoreDatas()
        {
            DataTable table = ReadQuery("GetAllScoreData");
            if(table != null && table.Rows.Count > 0)
            {
                List<ScoreData> returnList = new List<ScoreData>(table.Rows.Count);
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    DataRow currentRow = table.Rows[i];
                    int globalPosition = i + 1;
                    int score = (int)currentRow["Score"];
                    int userID = (int)currentRow["UserID"];

                    returnList.Add(new ScoreData(globalPosition, score, userID));
                }

                return returnList;
            }

            throw new NullReferenceException("No score data could be found.");
        }

        /// <summary>
        /// Returns all score data where the user who achieved it having the given userID. Throws an ArgumentException if the user could not be found. Throws an Exception on Error.
        /// </summary>
        /// <param name="userID">The ID of the user who achieved the score.</param>
        /// <returns></returns>
        public List<ScoreData> GetScoreDataByUserID(int userID)
        {
            DataTable table = ReadQuery("GetAllScoreData");
            if(table != null)
            {
                List<ScoreData> returnList = new List<ScoreData>();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    DataRow currentRow = table.Rows[i];
                    if((int)currentRow["UserID"] == userID)
                    {
                        int globalPosition = i + 1;
                        int score = (int)currentRow["Score"];

                        returnList.Add(new ScoreData(globalPosition, score, userID));
                    }
                }

                if(returnList.Count > 0)
                {
                    return returnList;
                }
            }
            
            throw new ArgumentException("Leaderboard entries for the user with the given userID (" + userID + ") could not be found.");
        }
    }
}
