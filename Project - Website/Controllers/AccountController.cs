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
        private IEnemy iEnemy = EnemyFactory.CreateEnemyInterface();
        private ILeaderboardEntry iLeaderboardEntry = LeaderboardEntryFactory.CreateLeaderboardInterface();
        private IUser iUser = UserFactory.CreateUserInterface();

        // An ID parameter needs to be added to allow for a specific user to be found
        [HttpGet()]
        public ActionResult AccountInfo(int id = 0)
        {
            // This is all sample data that should be retrieved from the database using the ID parameter
            bool userFound = iUser.GetUserDataByID(id);
            if(userFound)
            {
                AccountViewModel viewModel = new AccountViewModel();

                IUser selectedUser = iUser.SelectedUser;
                viewModel.Username = selectedUser.Name;

                bool personalEntriesFound = iLeaderboardEntry.GetLeaderboardEntriesByUserID(selectedUser.ID);
                if (personalEntriesFound)
                {
                    viewModel.PersonalLeaderboardEntries = new List<LeaderboardEntryViewModel>(iLeaderboardEntry.PersonalEntries.Count);
                    foreach (ILeaderboardEntry iEntry in iLeaderboardEntry.PersonalEntries)
                    {
                        viewModel.PersonalLeaderboardEntries.Add(new LeaderboardEntryViewModel(iEntry.ID, iEntry.GlobalPosition, iEntry.Score, iEntry.Username));
                    }
                }
                else
                {
                    viewModel.PersonalLeaderboardEntries = new List<LeaderboardEntryViewModel>();
                }

                bool personalEnemiesFound = iEnemy.GetEnemiesByUserID(selectedUser.ID);
                if(personalEnemiesFound)
                {
                    viewModel.PersonalEnemies = new List<EnemyViewModel>(iEnemy.Enemies.Count);
                    foreach(IEnemy enemy in iEnemy.Enemies)
                    {
                        viewModel.PersonalEnemies.Add(new EnemyViewModel(enemy.CreatorID, enemy.ID, enemy.CreatorName, enemy.Name));
                    }
                }
                else
                {
                    viewModel.PersonalEnemies = new List<EnemyViewModel>();
                }

                return View(viewModel);
            }

            // GOTO ERROR PAGE
            return RedirectToAction("Error", "Error", new { /* Error Message */ });
        }

        [HttpGet()]
        public ActionResult Login(string username = "")
        {
            LoginRegisterViewModel viewModel = new LoginRegisterViewModel();
            viewModel.Username = username;
            viewModel.HasError = false;

            return View(viewModel);
        }

        [HttpPost()]
        public ActionResult Login(string username, string password)
        {
            // Hand username and password over to the Logic layer who checks if the data is correct (together with the DAL)
            bool loginSuccess = iUser.Login(username, password);

            if (!loginSuccess)
            {
                LoginRegisterViewModel viewModel = new LoginRegisterViewModel();
                viewModel.Username = username;
                viewModel.HasError = true;

                return View(viewModel);
            }

            return RedirectToAction("AccountInfo", "Account", new { iUser.ID });
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
            bool registerSuccess = iUser.Register(username, password);
            if (!registerSuccess)
            {
                LoginRegisterViewModel viewModel = new LoginRegisterViewModel();
                viewModel.Username = username;
                viewModel.HasError = true;

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