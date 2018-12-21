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
    public class EnemyDAL : BaseDAL, IEnemyDAL
    {
        public EnemyDAL() : base() { }

        /// <summary>
        /// Returns all enemy data where the enemy has the given enemyID. Throws an ArgumentException if the enemy could not be found. Throws an Exception otherwise.
        /// </summary>
        /// <param name="enemyID">The ID of the enemy to find.</param>
        /// <returns></returns>
        public EnemyData GetEnemyDataByID(int enemyID)
        {
            DataTable table = ReadQuery("GetEnemyByID @enemyID", new DALParameters(enemyID, "@enemyID"));
            if (table.Rows.Count > 0)
            {
                int creatorID = (int)table.Rows[0]["UserID"];
                int difficulty = (int)table.Rows[0]["Difficulty"];
                string name = (string)table.Rows[0]["Name"];
                EnemyData returnStruct = new EnemyData(creatorID, difficulty, enemyID, name);

                return returnStruct;
            }

            throw new ArgumentException("An enemy with the given ID (" + enemyID + ") does not exist.");
        }

        /// <summary>
        /// Returns all enemy data found in the database. Throws an Exception on error.
        /// </summary>
        /// <returns></returns>
        public List<EnemyData> GetAllEnemyDatas()
        {
            DataTable table = ReadQuery("GetAllEnemyData");

            List<EnemyData> returnList = new List<EnemyData>(table.Rows.Count);
            foreach(DataRow row in table.Rows)
            {
                int creatorID = (int)row["UserID"];
                int difficulty = (int)row["Difficulty"];
                int id = (int)row["EnemyID"];
                string name = (string)row["Name"];

                returnList.Add(new EnemyData(creatorID, difficulty, id, name));
            }

            return returnList;
        }

        /// <summary>
        /// Returns all enemy data where the enemy has a creator with the given userID. Throws an Exception on Error.
        /// </summary>
        /// <param name="userID">The ID of the creator to use.</param>
        /// <returns></returns>
        public List<EnemyData> GetEnemyDatasByUserID(int userID)
        {
            DataTable table = ReadQuery("GetEnemyDataByUserID @userID", new DALParameters(userID, "@userID"));

            List<EnemyData> returnList = new List<EnemyData>(table.Rows.Count);
            foreach (DataRow row in table.Rows)
            {
                int creatorID = (int)row["UserID"];
                int difficulty = (int)row["Difficulty"];
                int id = (int)row["EnemyID"];
                string name = (string)row["Name"];

                returnList.Add(new EnemyData(creatorID, difficulty, id, name));
            }

            return returnList;
        }
    }
}
