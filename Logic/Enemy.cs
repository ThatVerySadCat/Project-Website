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
        /// 
        /// </summary>
        /// <param name="_creatorID">The ID of the user who made the enemy.</param>
        /// <param name="_id">The ID of the enemy.</param>
        /// <param name="_creatorName">The name of the user who made the enemy.</param>
        /// <param name="_name">The name of the enemy.</param>
        public Enemy(int _creatorID, int _id, string _creatorName, string _name)
        {
            CreatorID = _creatorID;
            ID = _id;
            CreatorName = _creatorName;
            Name = _name;
        }
    }
}
