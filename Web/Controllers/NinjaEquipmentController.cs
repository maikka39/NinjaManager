using Data;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class NinjaEquipmentController : Controller
    {
        private readonly INinjaEquipmentRepository _repo = new NinjaEquipmentRepository();
        
        public IActionResult RemoveEquipmentFromNinja(int ninjaId, int equipmentId)
        {
            if (ninjaId == 0 || equipmentId == 0) return null;
            if (_repo.Delete(ninjaId, equipmentId))
                return Accepted();
            return NotFound();
        }
    }
}