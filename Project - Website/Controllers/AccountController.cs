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
        private IAccount iAccount = AccountFactory.CreateAccountInterface();
        private IEnemyCollection iEnemyCollection = EnemyCollectionFactory.CreateEnemyCollectionInterface();
        private ILeaderboard iLeaderboard = LeaderboardFactory.CreateLeaderboardInterface();
        private IUser iUser = UserFactory.CreateUserInterface();
        private IUserCollection iUserCollection = UserCollectionFactory.CreateUserCollectionInterface();

        [HttpGet()]
        public ActionResult AccountInfo(int id = 0)
        {
            bool userFound = iUser.GetUserByID(id);
            if (userFound)
            {
                AccountInfoViewModel viewModel = new AccountInfoViewModel();

                viewModel.User = iUser;

                iLeaderboard.GetPersonalEntriesByUserID(viewModel.User.ID);
                viewModel.PersonalLeaderboardEntries = iLeaderboard.PersonalEntries;

                iEnemyCollection.GetEnemiesByUserID(viewModel.User.ID);
                viewModel.PersonalEnemies = iEnemyCollection.Enemies;

                return View(viewModel);
            }

            // GOTO ERROR PAGE
            // User could not be found
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
            bool loginSuccess = iAccount.Login(username, password);

            if (loginSuccess)
            {
                Session["UserID"] = iAccount.LoggedInUser.ID;
                Session["UserName"] = iAccount.LoggedInUser.Name;

                return RedirectToAction("AccountInfo", "Account", new { iAccount.LoggedInUser.ID });
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
            bool registerSuccess = iAccount.Register(username, password);
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
            bool returnValue = iAccount.IsUsernameAvailable(username);
            return Json(returnValue, JsonRequestBehavior.AllowGet);
        }
    }
}