using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Logic;
using LogicInterfaces;

namespace LogicFactory
{
    public class EnemyFactory
    {
        /// <summary>
        /// Returns a new IEnemy interface.
        /// </summary>
        /// <returns></returns>
        public static IEnemy CreateEnemyInterface()
        {
            return new Enemy();
        }
    }
}
