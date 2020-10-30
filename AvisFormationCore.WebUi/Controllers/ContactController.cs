using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AvisFormationCore.WebUi.Models;
using Data;
using Microsoft.AspNetCore.Mvc;

namespace AvisFormationCore.WebUi.Controllers
{
    public class ContactController : Controller
    {
        IContactRepository _context;

        public ContactController(IContactRepository context)
        {
            _context = context;
        }



        public IActionResult Index()
        {
            var vm = new EnvoiEmailViewModel();

            return View(vm);
        }

        public IActionResult SaveMessage(EnvoiEmailViewModel viewmodel)
        {

            if (!ModelState.IsValid)
            {
                return View("Index", viewmodel);
            }
            _context.SaveMessage(viewmodel.Nom, viewmodel.Email, viewmodel.Message);


            return View();
        }
    }
}
