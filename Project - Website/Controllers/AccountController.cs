using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Project___Website.Models;

namespace Project___Website.Controllers
{
    public class AccountController : Controller
    {
        // An ID parameter needs to be added to allow for a specific user to be found
        [HttpGet()]
        public ActionResult AccountInfo()
        {
            AccountViewModel viewModel = new AccountViewModel();

            // This is all sample data that should be retrieved from the database using the ID parameter
            viewModel.Username = "User 1";
            viewModel.PersonalEnemyList.Add(new EnemyViewModel(0, "User 1", "Enemy 1"));
            viewModel.PersonalEnemyList.Add(new EnemyViewModel(1, "User 1", "Enemy 2"));
            viewModel.PersonalEnemyList.Add(new EnemyViewModel(2, "User 2", "Enemy 3"));
            viewModel.PersonalLeaderboardEntries.Add(new LeaderboardEntryViewModel(1, 100, "User 1"));
            viewModel.PersonalLeaderboardEntries.Add(new LeaderboardEntryViewModel(6, 5, "User 1"));
            viewModel.PersonalLeaderboardEntries.Add(new LeaderboardEntryViewModel(7, 5, "User 1"));
            viewModel.PersonalLeaderboardEntries.Add(new LeaderboardEntryViewModel(8, 3, "User 1"));
            viewModel.PersonalLeaderboardEntries.Add(new LeaderboardEntryViewModel(9, 2, "User 1"));

            return View(viewModel);
        }

        [HttpGet()]
        public ActionResult Login()
        {
            LoginRegisterViewModel viewModel = new LoginRegisterViewModel();
            viewModel.Username = "";
            viewModel.HasError = false;

            return View(viewModel);
        }

        [HttpPost()]
        public ActionResult Login(string username, string password)
        {
            // Hand username and password over to the Logic layer who checks if the data is correct (together with the DAL)
            bool loginSuccess = false;

            if (!loginSuccess)
            {
                LoginRegisterViewModel viewModel = new LoginRegisterViewModel();
                viewModel.Username = username;
                viewModel.HasError = true;

                return View(viewModel);
            }

            return RedirectToAction("UserInfo", "UserInfo", new { /* Add User ID here later */});
        }

        [HttpGet()]
        public ActionResult Register()
        {
            LoginRegisterViewModel viewModel = new LoginRegisterViewModel();
            viewModel.Username = "";
            viewModel.HasError = false;

            return View(viewModel);
        }

        [HttpPost()]
        public ActionResult Register(string username, string password)
        {
            // Send the given username and password to the logic here to try and create an account
            
            bool registerSuccess = false;
            if (!registerSuccess)
            {
                LoginRegisterViewModel viewModel = new LoginRegisterViewModel();
                viewModel.Username = username;
                viewModel.HasError = true;

                return View(viewModel);
            }

            return RedirectToAction("AccountInfo", "Account", new { /* Reference User ID here */});
        }

        [HttpPost()]
        public JsonResult IsUsernameAvailable(string username)
        {
            // Get here if the given username is available or not and return the answer using the Json below.

            return Json(true, JsonRequestBehavior.AllowGet);
        }
    }
}