using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Project___Website.Models;

namespace Project___Website.Controllers
{
    public class BestiaryController : Controller
    {
        [HttpGet()]
        public ActionResult Bestiary()
        {
            EnemiesViewModel viewModel = new EnemiesViewModel();
            viewModel.Enemies.Add(new EnemyViewModel(0, "User 1", "Enemy 1"));
            viewModel.Enemies.Add(new EnemyViewModel(1, "User 1", "Enemy 2"));
            viewModel.Enemies.Add(new EnemyViewModel(2, "User 1", "Enemy 3"));
            viewModel.Enemies.Add(new EnemyViewModel(3, "User 2", "Enemy 4"));
            viewModel.Enemies.Add(new EnemyViewModel(4, "User 3", "Enemy 5"));
            viewModel.Enemies.Add(new EnemyViewModel(5, "User 4", "Enemy 6"));

            return View(viewModel);
        }
    }
}