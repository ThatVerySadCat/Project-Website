using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Structs;

namespace DALInterfaces
{
    public interface IStatisticsDAL
    {
        List<StatisticsData> GetEnemyCountPerUserStat();
        List<StatisticsData> GetEnemyCountPerDifficultyStat();
    }
}
