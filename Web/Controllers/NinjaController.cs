using System;
using System.Linq;
using System.Net;
using Data;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

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

        public IActionResult Details(int id)
        {
            if (id == 0) return RedirectToAction("Index");

            var ninja = _repo.GetOne(id);
            var equipments = _repo.GetEquipmentsFromNinja(ninja);
            return View(new NinjaViewModel(ninja, equipments));
        }

        public IActionResult SellEquipment(int ninjaId, int equipmentId)
        {
            if (ninjaId == 0 || equipmentId == 0) return RedirectToAction("Index");

            var ninja = _repo.GetOne(ninjaId);
            var equipment = _repo.GetEquipmentsFromNinja(ninja).FirstOrDefault(e => e.Id == equipmentId);

            if (ninja == null || equipment == null) return NotFound();

            ninja.Gold += equipment.Cost;

            var newEquipments = _repo.GetEquipmentsFromNinja(ninja).ToList();
            newEquipments.Remove(equipment);

            _repo.UpdateEquipments(ninja, newEquipments);

            _repo.Update(ninja);

            return RedirectToAction("Details", new {id = ninjaId});
        }

        public IActionResult Delete(int id)
        {
            var isRemoved = _repo.Delete(id);

            if (!isRemoved) Response.StatusCode = (int) HttpStatusCode.NotFound;

            return RedirectToAction("Index");
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
