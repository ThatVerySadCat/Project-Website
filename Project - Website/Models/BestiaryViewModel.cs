using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project___Website.Models
{
    public class BestiaryViewModel
    {
        /// <summary>
        /// The currently active enemy's view model.
        /// </summary>
        public EnemyViewModel ActiveEnemy
        {
            get;
            set;
        }
        /// <summary>
        /// A list of all enemy view models.
        /// </summary>
        public List<EnemyViewModel> Enemies
        {
            get;
            set;
        }

        public BestiaryViewModel()
        {
            Enemies = new List<EnemyViewModel>();
        }
    }
}