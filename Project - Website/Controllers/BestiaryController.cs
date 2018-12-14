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
        public ActionResult Bestiary(int id = 0)
        {
            BestiaryViewModel viewModel = new BestiaryViewModel();

            viewModel.Enemies.Add(new EnemyViewModel(0, 0, "User 1", "Enemy 1"));
            viewModel.Enemies.Add(new EnemyViewModel(0, 1, "User 1", "Enemy 2"));
            viewModel.Enemies.Add(new EnemyViewModel(0, 2, "User 1", "Enemy 3"));
            viewModel.Enemies.Add(new EnemyViewModel(1, 3, "User 2", "Enemy 4"));
            viewModel.Enemies.Add(new EnemyViewModel(2, 4, "User 3", "Enemy 5"));
            viewModel.Enemies.Add(new EnemyViewModel(3, 5, "User 4", "Enemy 6"));
            viewModel.Enemies.Add(new EnemyViewModel(4, 6, "User 5", "Enemy 7"));
            viewModel.Enemies.Add(new EnemyViewModel(5, 7, "User 6", "Enemy 8"));

            return View(viewModel);
        }

        [HttpPost()]
        public JsonResult SwitchActiveEnemy(int id)
        {
            // Get the actual correct enemy data based on the given ID
            EnemyViewModel newActiveModel = new EnemyViewModel(id, id, "User ?", "Enemy " + id);

            return Json(newActiveModel, JsonRequestBehavior.AllowGet);
        }
    }
}