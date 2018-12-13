using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LogicInterfaces;

namespace Logic
{
    public class LeaderboardEntry : ILeaderboardEntry
    {
        public int Position
        {
            get;
            set;
        }
        public int Score
        {
            get;
            set;
        }
        public string Username
        {
            get;
            set;
        }

        public LeaderboardEntry() { }

        public LeaderboardEntry(int _position, int _score, string _username)
        {
            Position = _position;
            Score = _score;
            Username = _username;
        }
    }
}
