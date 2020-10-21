using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AvisFormationCore.WebUi.Models;
using Microsoft.AspNetCore.Mvc;
using Data;
using System.Linq;


namespace AvisFormationCore.WebUi.Controllers
{
    public class FormationController : Controller
    {



        public IActionResult Index()
        {
                var vm = new ToutesLesFormationsViewModel();
                vm.Message = "Ceci est un mesage du controlleur";
                vm.Nombre = 93;

                return View(vm);
         }






        public IActionResult ToutesLesFormations()
         {
            FormationMemoryRepository repository = new FormationMemoryRepository();
            var listFormations = repository.GetAllFormations();

            return View(listFormations);
         }






        public IActionResult DetailsFormations(string idFormation)
        {
            int iIdFormation = -1;
            if(!Int32.TryParse(idFormation,out iIdFormation))
            {
                return RedirectToAction("ToutesLesFormations");
            }

            FormationMemoryRepository repository = new FormationMemoryRepository();
            var formation = repository.GetFormationById(iIdFormation);
            if(formation == null)
            {
                return RedirectToAction("ToutesLesFormations");
            }

            return View(formation);
        }
    }
}
