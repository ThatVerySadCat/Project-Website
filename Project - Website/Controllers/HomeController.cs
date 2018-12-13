using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Project___Website.Models;

namespace Project___Website.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet()]
        public ActionResult Index()
        {
            LeaderboardEntriesViewModel viewModel = new LeaderboardEntriesViewModel();

            // Get Top 5 Global Entries
            // The first 5 in the list can be global entries (use a for loop)
            // Swap these hard coded examples out for database retrieved entries later
            viewModel.GlobalLeaderboardEntries.Add(new LeaderboardEntryViewModel(0, 1, 100, "User 1"));
            viewModel.GlobalLeaderboardEntries.Add(new LeaderboardEntryViewModel(1, 2, 50, "User 2"));
            viewModel.GlobalLeaderboardEntries.Add(new LeaderboardEntryViewModel(2, 3, 25, "User 3"));
            viewModel.GlobalLeaderboardEntries.Add(new LeaderboardEntryViewModel(3, 4, 12, "User 4"));
            viewModel.GlobalLeaderboardEntries.Add(new LeaderboardEntryViewModel(4, 5, 6, "User 5"));

            // Get Top 5 Personal Entries
            // The bottom 5 in the list can be personal entries (use a for loop)
            // Swap these hard coded examples out for database retrieved entries later
            viewModel.PersonalLeaderboardEntries.Add(new LeaderboardEntryViewModel(0, 1, 100, "User 1"));
            viewModel.PersonalLeaderboardEntries.Add(new LeaderboardEntryViewModel(0, 6, 5, "User 1"));
            viewModel.PersonalLeaderboardEntries.Add(new LeaderboardEntryViewModel(0, 7, 5, "User 1"));
            viewModel.PersonalLeaderboardEntries.Add(new LeaderboardEntryViewModel(0, 8, 3, "User 1"));
            viewModel.PersonalLeaderboardEntries.Add(new LeaderboardEntryViewModel(0, 9, 2, "User 1"));

            return View(viewModel);
        }
    }
}