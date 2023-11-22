using Microsoft.AspNetCore.Mvc;

namespace MyCarBook.PresentationLayer.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
