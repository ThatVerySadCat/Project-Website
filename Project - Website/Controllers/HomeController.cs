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
        private ILeaderboard iLeaderboard = LeaderboardFactory.CreateLeaderboardInterface();

        [HttpGet()]
        public ActionResult Index()
        {
            int userID = -1;
            if(Session["UserID"] != null)
            {
                userID = (int)Session["UserID"];
            }

            IndexViewModel viewModel = new IndexViewModel();
            viewModel.GlobalLeaderboardEntries = new List<ILeaderboardEntry>();
            viewModel.PersonalLeaderboardEntries = new List<ILeaderboardEntry>();

            bool globalLeaderboardEntriesFound = iLeaderboard.GetAllGlobalEntries();
            if (globalLeaderboardEntriesFound)
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

        [HttpGet()]
        public ActionResult Stats()
        {
            StatsViewModel viewModel = new StatsViewModel();

            return View(viewModel);
        }
    }
}