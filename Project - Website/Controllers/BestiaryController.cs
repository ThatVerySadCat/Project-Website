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
    public class BestiaryController : Controller
    {
        private IEnemyCollection iEnemyCollection = EnemyCollectionFactory.CreateEnemyCollectionInterface();

        [HttpGet()]
        public ActionResult Bestiary(int id = 0)
        {
            BestiaryViewModel viewModel = new BestiaryViewModel();

            bool enemyFound = iEnemyCollection.GetEnemyByID(id);
            if (enemyFound)
            {
                viewModel.SelectedEnemy = iEnemyCollection.SelectedEnemy;
            }

            bool enemiesFound = iEnemyCollection.GetAllEnemies();
            viewModel.Enemies = iEnemyCollection.Enemies;

            return View(viewModel);
        }

        [HttpPost()]
        public JsonResult SwitchActiveEnemy(int id)
        {
            bool enemyFound = iEnemyCollection.GetEnemyByID(id);
            if (enemyFound)
            {
                return Json(iEnemyCollection.SelectedEnemy, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
    }
}