using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project___Website.Models
{
    public class BestiaryViewModel
    {
        public EnemyViewModel ActiveEnemy
        {
            get;
            set;
        }
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