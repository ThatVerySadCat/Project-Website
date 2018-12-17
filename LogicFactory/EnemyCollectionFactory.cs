using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Logic;
using LogicInterfaces;

namespace LogicFactory
{
    public class EnemyCollectionFactory
    {
        /// <summary>
        /// Returns a new IEnemyCollection interface.
        /// </summary>
        /// <returns></returns>
        public static IEnemyCollection CreateEnemyCollectionInterface()
        {
            return new EnemyCollection();
        }
    }
}
