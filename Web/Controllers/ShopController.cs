using Data;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class ShopController : Controller
    {
        readonly IEquipmentRepository _repo = new EquipmentRepository();

        public IActionResult Index()
        {

            return View();
        }
    }
}
