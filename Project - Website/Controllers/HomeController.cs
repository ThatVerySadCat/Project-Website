using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Project___Website.Models;

using LogicFactory;
using LogicInterfaces;

namespace Project___Website.Controllers
{
    public class HomeController : Controller
    {
        private ILeaderboardEntry iLeaderboardEntry = LeaderboardEntryFactory.CreateLeaderboardInterface();

        [HttpGet()]
        public ActionResult Index()
        {
            int userID = -1;
            if(Session["UserID"] != null)
            {
                userID = (int)Session["UserID"];
            }

            LeaderboardEntriesViewModel viewModel = new LeaderboardEntriesViewModel();

            bool globalLeaderboardEntriesFound = iLeaderboardEntry.GetAllGlobalLeaderboardEntries();
            if (globalLeaderboardEntriesFound)
            {
                viewModel.GlobalLeaderboardEntries = new List<LeaderboardEntryViewModel>(iLeaderboardEntry.GlobalEntries.Count);
                foreach(ILeaderboardEntry globalEntry in iLeaderboardEntry.GlobalEntries)
                {
                    viewModel.GlobalLeaderboardEntries.Add(new LeaderboardEntryViewModel(globalEntry.ID, globalEntry.GlobalPosition, globalEntry.Score, globalEntry.Username));
                }

                if (userID >= 0)
                {
                    bool leaderboardEntriesFound = iLeaderboardEntry.GetAllPersonalLeaderboardEntries(userID);
                    if (leaderboardEntriesFound)
                    {
                        viewModel.PersonalLeaderboardEntries = new List<LeaderboardEntryViewModel>(iLeaderboardEntry.PersonalEntries.Count);
                        foreach (ILeaderboardEntry personalEntry in iLeaderboardEntry.PersonalEntries)
                        {
                            viewModel.PersonalLeaderboardEntries.Add(new LeaderboardEntryViewModel(personalEntry.ID, personalEntry.GlobalPosition, personalEntry.Score, personalEntry.Username));
                        }
                    }
                    else
                    {
                        viewModel.PersonalLeaderboardEntries = new List<LeaderboardEntryViewModel>();
                    }
                }
            }
            else
            {
                viewModel.GlobalLeaderboardEntries = new List<LeaderboardEntryViewModel>();
                viewModel.PersonalLeaderboardEntries = new List<LeaderboardEntryViewModel>();
            }
            
            return View(viewModel);
        }
    }
}