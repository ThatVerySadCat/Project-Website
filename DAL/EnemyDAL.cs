using System;
using System.Collections.Generic;
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
        /// Returns all enemy data where the enemy has the given enemyID.
        /// </summary>
        /// <param name="enemyID">The ID of the enemy to find.</param>
        /// <returns></returns>
        public EnemyData GetEnemyDataByID(int enemyID) { throw new NotImplementedException(); }

        /// <summary>
        /// Returns all enemy data found in the database.
        /// </summary>
        /// <returns></returns>
        public List<EnemyData> GetAllEnemyDatas() { throw new NotImplementedException(); }

        /// <summary>
        /// Returns all enemy data where the enemy has a creator with the given userID.
        /// </summary>
        /// <param name="userID">The ID of the creator to use.</param>
        /// <returns></returns>
        public List<EnemyData> GetEnemyDataByUserID(int userID) { throw new NotImplementedException(); }
    }
}
