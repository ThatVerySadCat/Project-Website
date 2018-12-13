using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project___Website.Models
{
    public class EnemiesViewModel
    {
        public List<EnemyViewModel> Enemies
        {
            get;
            set;
        }

        public EnemiesViewModel()
        {
            Enemies = new List<EnemyViewModel>();
        }
    }
}