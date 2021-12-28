using CrudSystem.Data;
using CrudSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudSystem.Controllers
{
    public class CargoController : Controller
    {
       
        private readonly AplicationDbContext _context;


        public CargoController(AplicationDbContext context)
        {
            _context = context;
        }

        //exibir dado all
        public IActionResult Index()
        {
            IEnumerable<Cargo> listCargo = _context.Cargo;

            return View(listCargo);
        }

        //httpget CREATE do Cargo
        public IActionResult Create()
        {
            ViewBag.Departamentos = _context.Departamento.ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(Cargo cargo)

        {


            var model = new Cargo();

            if (ModelState.IsValid)
            {
                _context.Cargo.Add(cargo);
                _context.SaveChanges();

                TempData["mensaje"] = "Cadastrado com sucesso!";

                return RedirectToAction("Index");


            }
            return View();
        }
    }
}
