using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project___Website.Models
{
    public class EnemyViewModel
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
        /// The username of the user who made the enemy.
        /// </summary>
        public string CreatorUsername
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

        public EnemyViewModel() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_creatorID">The ID of the user who made the enemy.</param>
        /// <param name="_id">The ID of the enemy.</param>
        /// <param name="_creatorUsername">The username of the user who made the enemy.</param>
        /// <param name="_name">The name of the enemy.</param>
        public EnemyViewModel(int _creatorID, int _id, string _creatorUsername, string _name)
        {
            CreatorID = _creatorID;
            ID = _id;
            CreatorUsername = _creatorUsername;
            Name = _name;
        }
    }
}