using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Structs;

namespace DALInterfaces
{
    public interface IEnemyDAL
    {
        /// <summary>
        /// Returns all enemy data where the enemy has the given enemyID.
        /// </summary>
        /// <param name="enemyID">The ID of the enemy to find.</param>
        /// <returns></returns>
        EnemyData GetEnemyDataByID(int enemyID);
        /// <summary>
        /// Returns all enemy data found in the database.
        /// </summary>
        /// <returns></returns>
        List<EnemyData> GetAllEnemyDatas();
        /// <summary>
        /// Returns all enemy data where the enemy has a creator with the given userID.
        /// </summary>
        /// <param name="userID">The ID of the creator to use.</param>
        /// <returns></returns>
        List<EnemyData> GetEnemyDataByUserID(int userID);
    }
}
