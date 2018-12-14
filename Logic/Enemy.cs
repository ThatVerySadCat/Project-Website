using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LogicInterfaces;

namespace Logic
{
    public class Enemy : IEnemy
    {
        // HARD CODED DATA! REMOVE ASAP!
        private static Enemy hardCodedEnemy1 = new Enemy(0, 0, "TestName", "TestEnemy1");
        private static Enemy hardCodedEnemy2 = new Enemy(0, 1, "TestName", "TestEnemy2");
        private static Enemy hardCodedEnemy3 = new Enemy(0, 2, "TestName", "TestEnemy3");
        private static Enemy hardCodedEnemy4 = new Enemy(0, 3, "TestName", "TestEnemy4");

        private static Enemy hardCodedEnemy5 = new Enemy(1, 4, "AppleMan", "TestEnemy5");
        private static Enemy hardCodedEnemy6 = new Enemy(1, 5, "AppleMan", "TestEnemy6");

        private static Enemy hardCodedEnemy7 = new Enemy(2, 6, "EAPFan69", "TestEnemy7");
        // HARD CODED DATA! REMOVE ASAP!

        /// <summary>
        /// A currently selected enemy.
        /// </summary>
        public IEnemy SelectedEnemy
        {
            get;
            set;
        }
        /// <summary>
        /// The ID of the user who made the enemy.
        /// </summary>
        public int CreatorID
        {
            get;
            set;
        }
        /// <summary>
        /// The ID of the enemy.
        /// </summary>
        public int ID
        {
            get;
            set;
        }
        /// <summary>
        /// A list of enemies.
        /// </summary>
        public List<IEnemy> Enemies
        {
            get;
            set;
        }
        /// <summary>
        /// The name of the user who made the enemy.
        /// </summary>
        public string CreatorName
        {
            get;
            set;
        }
        /// <summary>
        /// The name of the enemy.
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        public Enemy() { }

        /// <summary>
        /// THIS CONSTRUCTOR HAS BEEN MADE FOR TESTING PURPOSES!
        /// REMOVE ASAP!
        /// </summary>
        /// <param name="_creatorID"></param>
        /// <param name="_id"></param>
        /// <param name="_creatorName"></param>
        /// <param name="_name"></param>
        public Enemy(int _creatorID, int _id, string _creatorName, string _name)
        {
            CreatorID = _creatorID;
            ID = _id;
            CreatorName = _creatorName;
            Name = _name;
        }

        /// <summary>
        /// Fills the Enemies property with all existing enemies and returns true. Returns false if there are no enemies.
        /// </summary>
        /// <returns></returns>
        public bool GetAllEnemies()
        {
            // Get the actual enemy data from the database here and check if there is any at all
            Enemies = new List<IEnemy>(7);
            Enemies.Add(hardCodedEnemy1);
            Enemies.Add(hardCodedEnemy2);
            Enemies.Add(hardCodedEnemy3);
            Enemies.Add(hardCodedEnemy4);
            Enemies.Add(hardCodedEnemy5);
            Enemies.Add(hardCodedEnemy6);
            Enemies.Add(hardCodedEnemy7);

            return true;
        }

        /// <summary>
        /// Fills the Enemies property with enemies whose creator has the given userID and returns true. Returns false if no enemies could be found.
        /// </summary>
        /// <param name="userID">The ID of the creator.</param>
        /// <returns></returns>
        public bool GetEnemiesByUserID(int userID)
        {
            if (hardCodedEnemy1.CreatorID == userID)
            {
                Enemies = new List<IEnemy>(4);
                Enemies.Add(hardCodedEnemy1);
                Enemies.Add(hardCodedEnemy2);
                Enemies.Add(hardCodedEnemy3);
                Enemies.Add(hardCodedEnemy4);

                return true;
            }
            else if(hardCodedEnemy5.CreatorID == userID)
            {
                Enemies = new List<IEnemy>(2);
                Enemies.Add(hardCodedEnemy5);
                Enemies.Add(hardCodedEnemy6);

                return true;
            }
            else if(hardCodedEnemy7.CreatorID == userID)
            {
                Enemies = new List<IEnemy>(1);
                Enemies.Add(hardCodedEnemy7);

                return true;
            }

            return false;
        }

        /// <summary>
        /// Sets the SelectedEnemy property with the enemy that has the given enemyID and returns true. Returns false if the enemy couldn't be found.
        /// </summary>
        /// <param name="enemyID">The ID of the enemy to get.</param>
        /// <returns></returns>
        public bool GetEnemyByID(int enemyID)
        {
            if(hardCodedEnemy1.ID == enemyID)
            {
                SelectedEnemy = hardCodedEnemy1;

                return true;
            }
            else if(hardCodedEnemy2.ID == enemyID)
            {
                SelectedEnemy = hardCodedEnemy2;

                return true;
            }
            else if (hardCodedEnemy3.ID == enemyID)
            {
                SelectedEnemy = hardCodedEnemy3;

                return true;
            }
            else if (hardCodedEnemy4.ID == enemyID)
            {
                SelectedEnemy = hardCodedEnemy4;

                return true;
            }
            else if (hardCodedEnemy5.ID == enemyID)
            {
                SelectedEnemy = hardCodedEnemy5;

                return true;
            }
            else if (hardCodedEnemy6.ID == enemyID)
            {
                SelectedEnemy = hardCodedEnemy6;

                return true;
            }
            else if (hardCodedEnemy7.ID == enemyID)
            {
                SelectedEnemy = hardCodedEnemy7;

                return true;
            }

            return false;
        }
    }
}
