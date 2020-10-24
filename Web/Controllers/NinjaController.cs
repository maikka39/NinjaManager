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

        public IActionResult Delete()
        {
            // Needs to be changed
            return null;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Name,Gold,SkinUrl")] Ninja ninja)
        {
            if (!ModelState.IsValid) return View(ninja);

            _repo.Create(ninja);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            if (id == 0) return RedirectToAction("Index");

            var ninja = _repo.GetOne(id);
            return View(ninja);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([Bind("Id,Name,Gold,SkinUrl")] Ninja ninja)
        {
            if (!ModelState.IsValid) return View(ninja);

            _repo.Update(ninja);


            return RedirectToAction("Index");
        }
    }
}
