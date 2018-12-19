using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    public struct StatisticsData
    {
        public string StatisticStr { get; set; }

        public StatisticsData(string _statisticsStr)
        {
            StatisticStr = _statisticsStr;
        }
    }
}
