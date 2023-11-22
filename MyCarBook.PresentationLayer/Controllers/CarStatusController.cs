using Microsoft.AspNetCore.Mvc;
using MyCarBook.BusinessLayer.Abstract;
using MyCarBookEntityLayer.Concrete;

namespace MyCarBook.PresentationLayer.Controllers
{
    public class CarStatusController : Controller
    {
        private readonly ICarStatusService _carStatusService;

        public CarStatusController(ICarStatusService carStatusService)
        {
            _carStatusService = carStatusService;
        }

        public IActionResult Index()
        {
            var values = _carStatusService.TGetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateCarStatus()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCarStatus(CarStatus carStatus)
        {
            _carStatusService.TInsert(carStatus);
            return View("Index");
        }
        public IActionResult RemoveCarStatus(int id)
        {
            var value = _carStatusService.TGetByID(id);
            _carStatusService.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateCarStatus(int id)
        {
            var value = _carStatusService.TGetByID(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateCarStatus(CarStatus carStatus)
        {
            _carStatusService.TUpdate(carStatus);
            return RedirectToAction("Index");
        }
    }
}
