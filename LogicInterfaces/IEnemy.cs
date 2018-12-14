﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicInterfaces
{
    public interface IEnemy
    {
        /// <summary>
        /// A currently selected enemy.
        /// </summary>
        IEnemy SelectedEnemy
        {
            get;
            set;
        }
        /// <summary>
        /// The ID of the user who made the enemy.
        /// </summary>
        int CreatorID
        {
            get;
            set;
        }
        /// <summary>
        /// The ID of the enemy.
        /// </summary>
        int ID
        {
            get;
            set;
        }
        /// <summary>
        /// A list of enemies.
        /// </summary>
        List<IEnemy> Enemies
        {
            get;
            set;
        }
        /// <summary>
        /// The name of the user who made the enemy.
        /// </summary>
        string CreatorName
        {
            get;
            set;
        }
        /// <summary>
        /// The name of the enemy.
        /// </summary>
        string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Fills the Enemies property with all existing enemies and returns true. Returns false if there are no enemies.
        /// </summary>
        /// <returns></returns>
        bool GetAllEnemies();
        /// <summary>
        /// Fills the Enemies property with enemies whose creator has the given userID and returns true. Returns false if no enemies could be found.
        /// </summary>
        /// <param name="userID">The ID of the creator.</param>
        /// <returns></returns>
        bool GetEnemiesByUserID(int userID);
        /// <summary>
        /// Sets the SelectedEnemy property with the enemy that has the given enemyID and returns true. Returns false if the enemy couldn't be found.
        /// </summary>
        /// <param name="enemyID">The ID of the enemy to get.</param>
        /// <returns></returns>
        bool GetEnemyByID(int enemyID);
    }
}