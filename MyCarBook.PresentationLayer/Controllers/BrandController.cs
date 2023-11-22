﻿using Microsoft.AspNetCore.Mvc;
using MyCarBook.BusinessLayer.Abstract;
using MyCarBookEntityLayer.Concrete;

namespace MyCarBook.PresentationLayer.Controllers
{
    public class BrandController : Controller
    {
        private readonly IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        public IActionResult Index()
        {
            var values = _brandService.TGetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddBrand()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddBrand(Brand brand)
        {
            _brandService.TInsert(brand);
            return RedirectToAction("Index"); 
        }
        public IActionResult DeleteBrand(int id)
        {
            var value = _brandService.TGetByID(id);
            _brandService.TDelete(value);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult UpdateBrand (int id)
        {
            var value = _brandService.TGetByID(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateBrand(Brand brand)
        {
            _brandService.TUpdate(brand);
            return RedirectToAction("Index");
        }
        //@*21.ders sonnu *@
    }
}
