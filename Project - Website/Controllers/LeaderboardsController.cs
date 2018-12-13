using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Project___Website.Models;

using LogicFactory;

namespace Project___Website.Controllers
{
    public class LeaderboardsController : Controller
    {
        [HttpGet()]
        public ActionResult Leaderboards()
        {
            LeaderboardEntriesViewModel viewModel = new LeaderboardEntriesViewModel();

            // Get Leaderboard Entries because they are the default display setting
            viewModel.GlobalLeaderboardEntries.Add(LeaderboardFactory.CreateLeaderboardEntry(1, 100, "User 1"));
            viewModel.GlobalLeaderboardEntries.Add(LeaderboardFactory.CreateLeaderboardEntry(2, 50, "User 2"));
            viewModel.GlobalLeaderboardEntries.Add(LeaderboardFactory.CreateLeaderboardEntry(3, 25, "User 3"));
            viewModel.GlobalLeaderboardEntries.Add(LeaderboardFactory.CreateLeaderboardEntry(4, 12, "User 4"));
            viewModel.GlobalLeaderboardEntries.Add(LeaderboardFactory.CreateLeaderboardEntry(5, 6, "User 5"));
            viewModel.GlobalLeaderboardEntries.Add(LeaderboardFactory.CreateLeaderboardEntry(6, 5, "User 1"));
            viewModel.GlobalLeaderboardEntries.Add(LeaderboardFactory.CreateLeaderboardEntry(7, 4, "User 1"));
            viewModel.GlobalLeaderboardEntries.Add(LeaderboardFactory.CreateLeaderboardEntry(8, 3, "User 1"));

            // Get Leaderboard Entries for when they need to be activated
            viewModel.PersonalLeaderboardEntries.Add(LeaderboardFactory.CreateLeaderboardEntry(1, 100, "User 1"));
            viewModel.PersonalLeaderboardEntries.Add(LeaderboardFactory.CreateLeaderboardEntry(6, 5, "User 1"));
            viewModel.PersonalLeaderboardEntries.Add(LeaderboardFactory.CreateLeaderboardEntry(7, 5, "User 1"));
            viewModel.PersonalLeaderboardEntries.Add(LeaderboardFactory.CreateLeaderboardEntry(8, 3, "User 1"));
            viewModel.PersonalLeaderboardEntries.Add(LeaderboardFactory.CreateLeaderboardEntry(9, 2, "User 1"));

            return View(viewModel);
        }
    }
}