using MvcCv.Models.Entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class HobbyController : Controller
    {
        GenericRepository<TblHobbies> repository = new GenericRepository<TblHobbies>();

        [HttpGet]
        public ActionResult Index()
        {
            var values = repository.TGetList();
            return View(values);
        }

        [HttpGet]
        public ActionResult UpdateHobby(int id)
        {
            var value = repository.Find(x => x.ID == id);
            ViewBag.id = id;
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateHobby(TblHobbies t)
        {
            var values = repository.Find(x=> x.ID== t.ID);
            values.Description1 = t.Description1;
            values.Description2 = t.Description2;
            repository.TUpdate(values);
            return RedirectToAction("Index");
        }
    }
}