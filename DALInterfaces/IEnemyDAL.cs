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
        /// Returns all enemy data where the enemy has the given enemyID. Throws an ArgumentException if the enemy could not be found. Throws an Exception otherwise.
        /// </summary>
        /// <param name="enemyID">The ID of the enemy to find.</param>
        /// <returns></returns>
        EnemyData GetEnemyDataByID(int enemyID);
        /// <summary>
        /// Returns all enemy data found in the database. Throws an Exception on error.
        /// </summary>
        /// <returns></returns>
        List<EnemyData> GetAllEnemyDatas();
        /// <summary>
        /// Returns all enemy data where the enemy has a creator with the given userID. Throws an Exception on Error.
        /// </summary>
        /// <param name="userID">The ID of the creator to use.</param>
        /// <returns></returns>
        List<EnemyData> GetEnemyDatasByUserID(int userID);
    }
}
