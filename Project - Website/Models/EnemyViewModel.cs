using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project___Website.Models
{
    public class EnemyViewModel
    {
        public int ID
        {
            get;
            set;
        }
        public string CreatorUsername
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }

        public EnemyViewModel() { }

        public EnemyViewModel(int _id, string _creatorUsername, string _name)
        {
            ID = _id;
            CreatorUsername = _creatorUsername;
            Name = _name;
        }
    }
}