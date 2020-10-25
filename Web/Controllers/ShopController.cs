using System;
using System.Net;
using Data;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class ShopController : Controller
    {
        private readonly IEquipmentRepository _repo = new EquipmentRepository();

        public IActionResult Index()
        {
            var equipments = _repo.GetAll();

            return View(equipments);
        }
        
        public IActionResult Create()
        {
            return View(new Equipment());
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Name,Description,ImageUrl,Cost,Category,Strength,Intelligence,Agility")] Equipment equipment)
        {
            foreach (var v in ModelState.Keys)
            {
                Console.WriteLine(v);
                Console.WriteLine(ModelState[v].AttemptedValue);
            }

            if (!ModelState.IsValid) return View(equipment);
            
            _repo.Create(equipment);
            
            
            return RedirectToAction("Index");
        }
        
        public IActionResult Edit(int id)
        {
            if (id == 0) return RedirectToAction("Index");
            
            var equipment = _repo.GetOne(id);
            return View(equipment);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([Bind("Id,Name,Description,ImageUrl,Cost,Category,Strength,Intelligence,Agility")] Equipment equipment)
        {
            if (!ModelState.IsValid) return View(equipment);
            
            _repo.Update(equipment);
            
            
            return RedirectToAction("Index");
        }
        
        public IActionResult Delete(int id)
        {
            var isRemoved = _repo.Delete(id);
            
            if (!isRemoved) Response.StatusCode = (int)HttpStatusCode.NotFound;
            
            return RedirectToAction("Index");
        }
    }
}
