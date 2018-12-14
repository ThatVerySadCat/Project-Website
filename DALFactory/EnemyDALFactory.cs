using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using DALInterfaces;

namespace DALFactory
{
    public class EnemyDALFactory
    {
        /// <summary>
        /// Returns a new Enemy DAL interface.
        /// </summary>
        /// <returns></returns>
        public static IEnemyDAL CreateEnemyDALInterface()
        {
            return new EnemyDAL();
        }
    }
}
