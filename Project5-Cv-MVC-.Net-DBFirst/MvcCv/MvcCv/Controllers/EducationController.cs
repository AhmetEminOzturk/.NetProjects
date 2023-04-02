using MvcCv.Models.Entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class EducationController : Controller
    {
    GenericRepository<TblEducation> repository = new GenericRepository<TblEducation>();
        public ActionResult Index()
        {
            var values = repository.TGetList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddEducation()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEducation(TblEducation t)
        {
            if (!ModelState.IsValid) 
            {
                return View("AddEducation");
            }
            repository.TAdd(t);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteEducation(int id)
        {
            var value = repository.Find(x=>x.ID == id);
            repository.TDelete(value); 
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateEducation(int id)
        {
            var value = repository.Find(x => x.ID == id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateEducation(TblEducation t)
        {
            if (!ModelState.IsValid)
            {
                return View("UpdateEducation");
            }
            var value = repository.Find(x => x.ID == t.ID);
            value.Title = t.Title;
            value.Subtitle1 = t.Subtitle1;
            value.Subtitle2 = t.Subtitle2;
            value.Date=t.Date;
            value.GPA= t.GPA;
            repository.TUpdate(value);
            return RedirectToAction("Index");
        }

    }
}