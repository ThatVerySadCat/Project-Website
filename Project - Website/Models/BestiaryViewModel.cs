using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using LogicInterfaces;

namespace Project___Website.Models
{
    public class BestiaryViewModel
    {
        /// <summary>
        /// A single IEnemy interface.
        /// </summary>
        public IEnemy SelectedEnemy { get; set; }
        /// <summary>
        /// A list of IEnemy interfaces.
        /// </summary>
        public List<IEnemy> Enemies { get; set; }
    }
}