using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AvisFormationCore.WebUi.Models;
using Data;
using Microsoft.AspNetCore.Mvc;

namespace AvisFormationCore.WebUi.Controllers
{
    public class AvisController : Controller
    {

        public IActionResult LaisserUnAvis(string idFormation)
        {
            int iIdFormation = -1;
            if (!Int32.TryParse(idFormation, out iIdFormation))
            {
                return RedirectToAction("ToutesLesFormations", "Formation");
            }

            FormationMemoryRepository repository = new FormationMemoryRepository();
            var formation = repository.GetFormationById(iIdFormation);
            if (formation == null)
            {
                return RedirectToAction("ToutesLesFormations", "Formation");
            }

            var vm = new LaisserUnAvisViewModel();
            vm.NomFormation = formation.Nom;
            vm.idFormation = formation.Id.ToString();

            return View(vm);
        }
          

        public IActionResult SaveComment(LaisserUnAvisViewModel viewModel)
        {
            if(!ModelState.IsValid)
            {
                return View ("LaisserUnAvis", viewModel);
            }

            if (String.IsNullOrEmpty(viewModel.Nom) || String.IsNullOrEmpty(viewModel.Note))
            {
                return RedirectToAction("LaisserUnAvis", new { idFormation = viewModel.idFormation });
            }

            AvisRepository repository = new AvisRepository();
            repository.SaveAvis(viewModel.Commentaire, viewModel.Nom, viewModel.idFormation);

            return RedirectToAction("DetailsFormation", "Formation", new { idFormation = viewModel.idFormation });

        }

    }
}
