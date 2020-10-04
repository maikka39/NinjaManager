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
        public IActionResult Edit()
        {
            var equipments = _repo.GetAll();

            return View(equipments);
        }
    }
}
