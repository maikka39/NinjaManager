using Data;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers {
    public class NinjaController : Controller {
        readonly INinjaRepository _repo = new NinjaRepository ();

        public IActionResult Index () {
            var model = _repo.GetAll ();

            return View(model);
        }
    }
}
