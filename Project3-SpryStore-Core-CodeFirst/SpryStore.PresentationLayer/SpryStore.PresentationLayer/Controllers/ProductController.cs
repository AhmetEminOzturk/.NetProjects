﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SpryStore.BusinessLayer.Abstract;
using SpryStore.EntityLayer.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace SpryStore.PresentationLayer.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var values = _productService.TGetProductListWithCategory();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            List<SelectListItem> values = (from x in _categoryService.TGetList()
                                           select new SelectListItem
                                           {
                                               Text= x.CategoryName,
                                               Value= x.CategoryID.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product product) 
        {
            _productService.TInsert(product);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteProduct(int id)
        {
            var value = _productService.TGetByID(id);
            _productService.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var value = _productService.TGetByID(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {
           _productService.TUpdate(product);
            return RedirectToAction("Index");
        }

        public IActionResult GetLast4Products()
        {
            var values = _productService.TGetLast4Product();
            return View(values);
        }
    }
}
