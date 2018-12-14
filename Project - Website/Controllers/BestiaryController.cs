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
        private IEnemy iEnemy = EnemyFactory.CreateEnemyInterface();

        [HttpGet()]
        public ActionResult Bestiary(int id = 0)
        {
            BestiaryViewModel viewModel = new BestiaryViewModel();

            bool enemyFound = iEnemy.GetEnemyByID(id);
            if(enemyFound)
            {
                IEnemy selectedEnemy = iEnemy.SelectedEnemy;
                viewModel.ActiveEnemy = new EnemyViewModel(selectedEnemy.CreatorID, selectedEnemy.ID, selectedEnemy.CreatorName, selectedEnemy.Name);
            }
            else
            {
                viewModel.ActiveEnemy = new EnemyViewModel(-1, -1, "-", "-");
            }

            bool enemiesFound = iEnemy.GetAllEnemies();
            if(enemiesFound)
            {
                viewModel.Enemies = new List<EnemyViewModel>(iEnemy.Enemies.Count);
                foreach (IEnemy enemy in iEnemy.Enemies)
                {
                    viewModel.Enemies.Add(new EnemyViewModel(enemy.CreatorID, enemy.ID, enemy.CreatorName, enemy.Name));
                }
            }
            else
            {
                viewModel.Enemies = new List<EnemyViewModel>();
            }

            return View(viewModel);
        }

        [HttpPost()]
        public JsonResult SwitchActiveEnemy(int id)
        {
            bool enemyFound = iEnemy.GetEnemyByID(id);
            if(enemyFound)
            {
                IEnemy selectedEnemy = iEnemy.SelectedEnemy;
                return Json(new EnemyViewModel(selectedEnemy.CreatorID, selectedEnemy.ID, selectedEnemy.CreatorName, selectedEnemy.Name), JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new EnemyViewModel(-1, -1, "-", "-"), JsonRequestBehavior.AllowGet);
            }
        }
    }
}