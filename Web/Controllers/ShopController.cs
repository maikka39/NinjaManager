using System;
using System.Linq;
using System.Net;
using Data;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class ShopController : Controller
    {
        private readonly IEquipmentRepository _repo = new EquipmentRepository();

        public IActionResult Index()
        {
            var equipments = _repo.GetAll();

            return View(equipments.Select(e => new EquipmentIndexViewModel(e)));
        }
        
        public IActionResult Create()
        {
            return View(new EquipmentCreateViewModel());
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Name,Description,ImageUrl,Cost,Category,Strength,Intelligence,Agility")] Equipment equipment)
        {
            if (!ModelState.IsValid) return View(new EquipmentCreateViewModel(equipment));
            
            _repo.Create(equipment);

            return RedirectToAction("Index");
        }
        
        public IActionResult Edit(int id)
        {
            if (id == 0) return RedirectToAction("Index");
            
            var equipment = _repo.GetOne(id);
            return View(new EquipmentEditViewModel(equipment));
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([Bind("Id,Name,Description,ImageUrl,Cost,Category,Strength,Intelligence,Agility")] Equipment equipment)
        {
            if (!ModelState.IsValid) return View(new EquipmentEditViewModel(equipment));
            
            _repo.Update(equipment);
            
            return RedirectToAction("Index");
        }
        
        public IActionResult Delete(int id)
        {
            var isRemoved = _repo.Delete(id);
            
            if (!isRemoved) return NotFound();
            
            return RedirectToAction("Index");
        }
    }
}
