using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicInterfaces
{
    public interface ILeaderboardEntry
    {
        int Position
        {
            get;
            set;
        }
        int Score
        {
            get;
            set;
        }
        string Username
        {
            get;
            set;
        }
    }
}
