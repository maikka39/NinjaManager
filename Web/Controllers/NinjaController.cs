using System;
using Data;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class NinjaController : Controller
    {
        private readonly INinjaRepository _repo = new NinjaRepository();

        public IActionResult Index()
        {
            var model = _repo.GetAll();

            return View(model);
        }
        
        public IActionResult Create()
        {
            return View(new Ninja());
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Name,Gold")] Ninja ninja)
        {
            foreach (var v in ModelState.Keys)
            {
                Console.WriteLine(v);
                Console.WriteLine(ModelState[v].AttemptedValue);
            }

            if (!ModelState.IsValid) return View(ninja);
            
            _repo.Create(ninja);
            
            
            return RedirectToAction("Index");
        }
    }
}