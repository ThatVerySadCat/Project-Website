using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicInterfaces
{
    public interface IEnemy
    {
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
    }
}
