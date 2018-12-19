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
    public class StatisticsDAL : BaseDAL, IStatisticsDAL
    {
        public StatisticsDAL() : base() { }

        public List<StatisticsData> GetEnemyCountPerDifficultyStat()
        {
            DataTable table = ReadQuery("SELECT Count(EnemyID), Difficulty FROM Enemy GROUP BY Difficulty");

            List<StatisticsData> returnList = new List<StatisticsData>(table.Rows.Count);
            foreach (DataRow row in table.Rows)
            {
                int enemyCount = (int)row["Column1"];
                int difficulty = (int)row["Difficulty"];

                returnList.Add(new StatisticsData(enemyCount + " Enemies of Difficulty " + difficulty));
            }

            return returnList;
        }

        public List<StatisticsData> GetEnemyCountPerUserStat()
        {
            DataTable table = ReadQuery("SELECT Count(Enemy.EnemyID), [User].Username " +
                "FROM Enemy INNER JOIN [User] ON Enemy.UserID = [User].UserID " +
                "GROUP BY Username");

            List<StatisticsData> returnList = new List<StatisticsData>(table.Rows.Count);
            foreach(DataRow row in table.Rows)
            {
                int enemyCount = (int)row["Column1"];
                string username = (string)row["Username"];

                returnList.Add(new StatisticsData(username + " has created a total of " + enemyCount + " enemies."));
            }

            return returnList;
        }
    }
}
