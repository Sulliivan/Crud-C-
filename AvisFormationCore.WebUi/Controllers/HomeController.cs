﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AvisFormationCore.WebUi.Models;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace AvisFormationCore.WebUi.Controllers
{ 
    public class HomeController : Controller
    {

        IFormationRepository _repository;

        public HomeController(IFormationRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var listFormations = _repository.GetFormations(4);
            var vm = new List<DetailFormationViewModel>();
            foreach (var f in listFormations)
            {
                vm.Add(
                    new DetailFormationViewModel
                    {
                        Formation = f,
                        NoteMoyenne = f.Avis.Select(a => a.Note)
                        .DefaultIfEmpty(0).Average()
                    });

            }

            return View(vm);
        }

    }
}
