using CrudSystem.Data;
using CrudSystem.Models;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Create()
        {

            return View();
        }
    }
}
