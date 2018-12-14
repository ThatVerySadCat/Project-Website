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
    public class LeaderboardsController : Controller
    {
        private ILeaderboardEntry iLeaderboardEntry = LeaderboardEntryFactory.CreateLeaderboardInterface();

        [HttpGet()]
        public ActionResult Leaderboards()
        {
            int userID = -1;
            if(Session["UserID"] != null)
            {
                userID = (int)Session["UserID"];
            }

            LeaderboardEntriesViewModel viewModel = new LeaderboardEntriesViewModel();
            viewModel.GlobalLeaderboardEntries = new List<LeaderboardEntryViewModel>();
            viewModel.PersonalLeaderboardEntries = new List<LeaderboardEntryViewModel>();

            bool globalLeaderboardEntries = iLeaderboardEntry.GetAllGlobalLeaderboardEntries();
            if(globalLeaderboardEntries)
            {
                foreach(ILeaderboardEntry entry in iLeaderboardEntry.GlobalEntries)
                {
                    viewModel.GlobalLeaderboardEntries.Add(new LeaderboardEntryViewModel(entry.ID, entry.GlobalPosition, entry.Score, entry.Username));
                }

                if (userID >= 0)
                {
                    bool personalLeaderboardEntries = iLeaderboardEntry.GetAllPersonalLeaderboardEntries(userID);
                    if(personalLeaderboardEntries)
                    {
                        foreach(ILeaderboardEntry entry in iLeaderboardEntry.PersonalEntries)
                        {
                            viewModel.PersonalLeaderboardEntries.Add(new LeaderboardEntryViewModel(entry.ID, entry.GlobalPosition, entry.Score, entry.Username));
                        }
                    }
                }
            }

            return View(viewModel);
        }
    }
}