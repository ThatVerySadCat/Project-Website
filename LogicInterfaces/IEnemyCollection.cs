using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicInterfaces
{
    public interface IEnemyCollection
    {
        /// <summary>
        /// A single IEnemy interface.
        /// </summary>
        IEnemy SelectedEnemy { get; set; }
        /// <summary>
        /// A list of IEnemy interfaces.
        /// </summary>
        List<IEnemy> Enemies { get; set; }

        /// <summary>
        /// Fills the Enemies property with available enemy data and returns true. Returns false if no enemy data could be found.
        /// </summary>
        /// <returns></returns>
        bool GetAllEnemies();
        /// <summary>
        /// Fills the Enemies property with enemy data belonging to the creator with the given userID and returns true. Returns false if no enemy data could be found.
        /// </summary>
        /// <param name="userID">The ID of the enemy creator.</param>
        /// <returns></returns>
        bool GetEnemiesByUserID(int userID);
        /// <summary>
        /// Sets the SelectedEnemy property to the enemy with the given enemyID and returns true. Returns false if the enemy could not be found.
        /// </summary>
        /// <param name="enemyID">The ID to search by.</param>
        /// <returns></returns>
        bool GetEnemyByID(int enemyID);
    }
}
