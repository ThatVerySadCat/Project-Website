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
    public class EnemyCollection : IEnemyCollection
    {
        /// <summary>
        /// A single IEnemy interface.
        /// </summary>
        public IEnemy SelectedEnemy { get; set; }
        /// <summary>
        /// A list of IEnemy interfaces.
        /// </summary>
        public List<IEnemy> Enemies { get; set; }

        private IEnemyDAL iEnemyDAL = EnemyDALFactory.CreateEnemyDALInterface();
        private IUserDAL iUserDAL = UserDALFactory.CreateUserDALInterface();

        /// <summary>
        /// Fills the Enemies property with available enemy data and returns true. Returns false if no enemy data could be found.
        /// </summary>
        /// <returns></returns>
        public bool GetAllEnemies()
        {
            List<EnemyData> enemyDatas = iEnemyDAL.GetAllEnemyDatas();
            Enemies = new List<IEnemy>(enemyDatas.Count);
            foreach(EnemyData enemyData in enemyDatas)
            {
                try
                {
                    UserData creatorData = iUserDAL.GetUserDataByID(enemyData.CreatorID);
                    Enemies.Add(new Enemy(creatorData.ID, enemyData.ID, creatorData.Name, enemyData.Name));
                }
                catch (Exception)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Fills the Enemies property with enemy data belonging to the creator with the given userID and returns true. Returns false if no enemy data could be found.
        /// </summary>
        /// <param name="userID">The ID of the enemy creator.</param>
        /// <returns></returns>
        public bool GetEnemiesByUserID(int userID)
        {
            List<EnemyData> enemyDatas = iEnemyDAL.GetEnemyDatasByUserID(userID);
            Enemies = new List<IEnemy>(enemyDatas.Count);
            foreach(EnemyData enemyData in enemyDatas)
            {
                try
                {
                    UserData userData = iUserDAL.GetUserDataByID(userID);
                    Enemies.Add(new Enemy(enemyData.CreatorID, enemyData.ID, userData.Name, enemyData.Name));
                }
                catch (Exception)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Sets the SelectedEnemy property to the enemy with the given enemyID and returns true. Returns false if the enemy could not be found.
        /// </summary>
        /// <param name="enemyID">The ID to search by.</param>
        /// <returns></returns>
        public bool GetEnemyByID(int enemyID)
        {
            try
            {
                EnemyData enemyData = iEnemyDAL.GetEnemyDataByID(enemyID);
                UserData userData = iUserDAL.GetUserDataByID(enemyData.CreatorID);
                SelectedEnemy = new Enemy(enemyData.CreatorID, enemyData.ID, userData.Name, enemyData.Name);

                return true;
            }
            catch (ArgumentException) { }

            return false;
        }
    }
}
