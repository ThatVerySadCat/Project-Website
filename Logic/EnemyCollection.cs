using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LogicInterfaces;

namespace Logic
{
    public class EnemyCollection : IEnemyCollection
    {
        // HARD CODED DATA! REMOVE ASAP!
        private static IEnemy[] hardCodedEnemies = new IEnemy[] {
            new Enemy(0, 0, "TestName", "TestEnemy1"),
            new Enemy(0, 1, "TestName", "TestEnemy2"),
            new Enemy(0, 2, "TestName", "TestEnemy3"),
            new Enemy(0, 3, "TestName", "TestEnemy4"),
            new Enemy(1, 4, "AppleMan", "TestEnemy5"),
            new Enemy(1, 5, "AppleMan", "TestEnemy6"),
            new Enemy(2, 6, "EAPFan69", "TestEnemy7") };
        // HARD CODED DATA! REMOVE ASAP!

        /// <summary>
        /// A single IEnemy interface.
        /// </summary>
        public IEnemy SelectedEnemy { get; set; }
        /// <summary>
        /// A list of IEnemy interfaces.
        /// </summary>
        public List<IEnemy> Enemies { get; set; }

        /// <summary>
        /// Fills the Enemies property with available enemy data and returns true. Returns false if no enemy data could be found.
        /// </summary>
        /// <returns></returns>
        public bool GetAllEnemies()
        {
            // Get Enemy Data from DAL here.
            Enemies = new List<IEnemy>(hardCodedEnemies);

            return true;
        }

        /// <summary>
        /// Fills the Enemies property with enemy data belonging to the creator with the given userID and returns true. Returns false if no enemy data could be found.
        /// </summary>
        /// <param name="userID">The ID of the enemy creator.</param>
        /// <returns></returns>
        public bool GetEnemiesByUserID(int userID)
        {
            // Get Enemy Data with specific CreatorID from DAL here.
            Enemies = hardCodedEnemies.Where(x => x.CreatorID == userID).ToList();
            if(Enemies != null && Enemies.Count > 0)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Sets the SelectedEnemy property to the enemy with the given enemyID and returns true. Returns false if the enemy could not be found.
        /// </summary>
        /// <param name="enemyID">The ID to search by.</param>
        /// <returns></returns>
        public bool GetEnemyByID(int enemyID)
        {
            SelectedEnemy = hardCodedEnemies.Where(x => x.ID == enemyID).FirstOrDefault();
            if(SelectedEnemy != null)
            {
                return true;
            }

            return false;
        }
    }
}
