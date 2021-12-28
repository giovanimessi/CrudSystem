using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudSystem.Controllers
{
    public class ProjetoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
