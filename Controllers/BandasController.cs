using Microsoft.AspNetCore.Mvc;
using MusicZone2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicZone2.Controllers
{
    public class BandasController : Controller
    {
        public IActionResult Index()
        {
            List<Banda> bandas = Repositório.Bandas;
            return View(bandas);
        }

        public IActionResult AddBanda()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBanda(Banda novaBanda)
        {
            if (ModelState.IsValid)
            {
                Repositório.AddBanda(novaBanda);
                return View("BandaConfirmada", novaBanda);
            }
            return View();
        }
    }
}
