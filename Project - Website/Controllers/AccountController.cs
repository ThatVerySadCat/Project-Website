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
    public class AccountController : Controller
    {
        private IEnemyCollection iEnemyCollection = EnemyCollectionFactory.CreateEnemyCollectionInterface();
        private ILeaderboard iLeaderboard = LeaderboardFactory.CreateLeaderboardInterface();
        private IUser iUser = UserFactory.CreateUserInterface();
        private IUserCollection iUserCollection = UserCollectionFactory.CreateUserCollectionInterface();

        // An ID parameter needs to be added to allow for a specific user to be found
        [HttpGet()]
        public ActionResult AccountInfo(int id = 0)
        {
            // This is all sample data that should be retrieved from the database using the ID parameter
            bool userFound = iUserCollection.GetUserByID(id);
            if(userFound)
            {
                AccountInfoViewModel viewModel = new AccountInfoViewModel();

                viewModel.User = iUserCollection.SelectedUser;

                bool personalEntriesFound = iLeaderboard.GetPersonalEntriesByUserID(viewModel.User.ID);
                if (personalEntriesFound)
                {
                    viewModel.PersonalLeaderboardEntries = iLeaderboard.PersonalEntries;
                }
                else
                {
                    viewModel.PersonalLeaderboardEntries = new List<ILeaderboardEntry>();
                }

                bool personalEnemiesFound = iEnemyCollection.GetEnemiesByUserID(viewModel.User.ID);
                if(personalEnemiesFound)
                {
                    viewModel.PersonalEnemies = iEnemyCollection.Enemies;
                }
                else
                {
                    viewModel.PersonalEnemies = new List<IEnemy>();
                }

                return View(viewModel);
            }

            // GOTO ERROR PAGE
            return RedirectToAction("Error", "Error", new { /* Error Message */ });
        }

        [HttpGet()]
        public ActionResult Login(string username = "")
        {
            LoginViewModel viewModel = new LoginViewModel();
            viewModel.Name = username;
            viewModel.HasFailed = false;

            return View(viewModel);
        }

        [HttpPost()]
        public ActionResult Login(string username, string password)
        {
            // Hand username and password over to the Logic layer who checks if the data is correct (together with the DAL)
            bool loginSuccess = iUser.Login(username, password);

            if(loginSuccess)
            {
                Session["UserID"] = iUser.ID;
                Session["UserName"] = iUser.Name;

                return RedirectToAction("AccountInfo", "Account", new { iUser.ID });
            }

            LoginViewModel viewModel = new LoginViewModel();
            viewModel.Name = username;
            viewModel.HasFailed = true;

            return View(viewModel);
        }

        [HttpGet()]
        public ActionResult Logout()
        {
            Session["UserID"] = null;

            return RedirectToAction("Login", "Account");
        }

        [HttpGet()]
        public ActionResult Register()
        {
            RegisterViewModel viewModel = new RegisterViewModel();
            viewModel.Name = "";
            viewModel.HasFailed = false;

            return View(viewModel);
        }

        [HttpPost()]
        public ActionResult Register(string username, string password)
        {
            // Send the given username and password to the logic here to try and create an account
            bool registerSuccess = iUser.Register(username, password);
            if (!registerSuccess)
            {
                RegisterViewModel viewModel = new RegisterViewModel();
                viewModel.Name = username;
                viewModel.HasFailed = true;

                return View(viewModel);
            }

            return RedirectToAction("Login", "Account", new { username });
        }

        [HttpPost()]
        public JsonResult IsUsernameAvailable(string username)
        {
            bool returnValue = iUser.IsUsernameAvailable(username);
            return Json(returnValue, JsonRequestBehavior.AllowGet);
        }
    }
}