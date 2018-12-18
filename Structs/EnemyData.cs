using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    public struct EnemyData
    {
        /// <summary>
        /// The ID of the user who created the enemy.
        /// </summary>
        public int CreatorID
        {
            get;
            private set;
        }
        /// <summary>
        /// A number indicating the difficulty of the enemy.
        /// </summary>
        public int Difficulty
        {
            get;
            private set;
        }
        /// <summary>
        /// The unique ID belonging to the enemy.
        /// </summary>
        public int ID
        {
            get;
            private set;
        }
        /// <summary>
        /// The name of the enemy.
        /// </summary>
        public string Name
        {
            get;
            private set;
        }

        public EnemyData(int _creatorID, int _difficulty, int _id, string _name)
        {
            CreatorID = _creatorID;
            Difficulty = _difficulty;
            ID = _id;
            Name = _name;
        }
    }
}
