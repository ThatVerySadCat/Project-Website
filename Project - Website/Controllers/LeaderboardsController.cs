using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Project___Website.Models;

namespace Project___Website.Controllers
{
    public class LeaderboardsController : Controller
    {
        [HttpGet()]
        public ActionResult Leaderboards()
        {
            LeaderboardEntriesViewModel viewModel = new LeaderboardEntriesViewModel();

            // Get Leaderboard Entries because they are the default display setting
            viewModel.GlobalLeaderboardEntries.Add(new LeaderboardEntryViewModel(0, 1, 100, "User 1"));
            viewModel.GlobalLeaderboardEntries.Add(new LeaderboardEntryViewModel(1, 2, 50, "User 2"));
            viewModel.GlobalLeaderboardEntries.Add(new LeaderboardEntryViewModel(2, 3, 25, "User 3"));
            viewModel.GlobalLeaderboardEntries.Add(new LeaderboardEntryViewModel(3, 4, 12, "User 4"));
            viewModel.GlobalLeaderboardEntries.Add(new LeaderboardEntryViewModel(4, 5, 6, "User 5"));
            viewModel.GlobalLeaderboardEntries.Add(new LeaderboardEntryViewModel(0, 6, 5, "User 1"));
            viewModel.GlobalLeaderboardEntries.Add(new LeaderboardEntryViewModel(0, 7, 4, "User 1"));
            viewModel.GlobalLeaderboardEntries.Add(new LeaderboardEntryViewModel(0, 8, 3, "User 1"));

            // Get Leaderboard Entries for when they need to be activated
            viewModel.PersonalLeaderboardEntries.Add(new LeaderboardEntryViewModel(0, 1, 100, "User 1"));
            viewModel.PersonalLeaderboardEntries.Add(new LeaderboardEntryViewModel(0, 6, 5, "User 1"));
            viewModel.PersonalLeaderboardEntries.Add(new LeaderboardEntryViewModel(0, 7, 5, "User 1"));
            viewModel.PersonalLeaderboardEntries.Add(new LeaderboardEntryViewModel(0, 8, 3, "User 1"));
            viewModel.PersonalLeaderboardEntries.Add(new LeaderboardEntryViewModel(0, 9, 2, "User 1"));

            return View(viewModel);
        }
    }
}