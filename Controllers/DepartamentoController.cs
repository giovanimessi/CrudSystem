using CrudSystem.Data;
using CrudSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudSystem.Controllers
{
    public class DepartamentoController : Controller
    {
        private readonly AplicationDbContext _context;


        public DepartamentoController(AplicationDbContext context)
        {
            _context = context;
        }

        //LISTAGEM
        public IActionResult Index()
        {
            IEnumerable<Departamento> listDepartamentos = _context.Departamento;

            return View(listDepartamentos);
        }


        //httpget CREATE
        public IActionResult Create()
        {

            return View();
        }

        //httpost create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Departamento departamento)
        {
            if (ModelState.IsValid)
            {
                _context.Departamento.Add(departamento);
                _context.SaveChanges();

                TempData["mensaje"] = "Cadastrado com sucesso!";
                return RedirectToAction("Index");

                
            }
            return View();
        }
        //httpget edit
        public IActionResult Edit(int? id)
        {
            if (id == null ||id == 0)
            {
                return NotFound();
            }

            //o departamento pelo ID
            var departamento = _context.Departamento.Find(id);

            if (departamento == null)
            {
                return NotFound();
            }
            

            return View(departamento);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Departamento departamento)
        {
            if (ModelState.IsValid)
            {
                _context.Departamento.Update(departamento);
                _context.SaveChanges();

                TempData["mensaje"] = "Atualizado com sucesso!";
                return RedirectToAction("Index");


            }
            return View();
        }

        //httpget delete
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            //o departamento pelo ID
            var departamento = _context.Departamento.Find(id);

            if (departamento == null)
            {
                return NotFound();
            }


            return View(departamento);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteDepartamento(int? CODIGO)
        {

            //obter por id
            var departamento = _context.Departamento.Find(CODIGO);

            if (departamento == null)
            {
                return NotFound();


            }

            _context.Departamento.Remove(departamento);
            _context.SaveChanges();

            TempData["mensaje"] = "Excluido com sucesso!";
            return RedirectToAction("Index");

            
        }

    }
}
