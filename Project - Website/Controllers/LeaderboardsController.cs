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
        private ILeaderboard iLeaderboard = LeaderboardFactory.CreateLeaderboardInterface();

        [HttpGet()]
        public ActionResult Leaderboards()
        {
            int userID = -1;
            if (Session["UserID"] != null)
            {
                userID = (int)Session["UserID"];
            }

            LeaderboardsViewModel viewModel = new LeaderboardsViewModel();
            viewModel.GlobalLeaderboardEntries = new List<ILeaderboardEntry>();
            viewModel.PersonalLeaderboardEntries = new List<ILeaderboardEntry>();

            bool globalLeaderboardEntries = iLeaderboard.GetAllGlobalEntries();
            if (globalLeaderboardEntries)
            {
                viewModel.GlobalLeaderboardEntries = iLeaderboard.GlobalEntries;

                if (userID >= 0)
                {
                    iLeaderboard.GetPersonalEntriesByUserID(userID);
                    viewModel.PersonalLeaderboardEntries = iLeaderboard.PersonalEntries;
                }
            }

            return View(viewModel);
        }
    }
}