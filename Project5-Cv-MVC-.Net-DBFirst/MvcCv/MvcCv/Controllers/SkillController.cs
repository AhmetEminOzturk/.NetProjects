using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Repositories;

namespace MvcCv.Controllers
{
    public class SkillController : Controller
    {
      
        GenericRepository<TblSkills> repository= new GenericRepository<TblSkills>();
        public ActionResult Index()
        {
            var values = repository.TGetList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddSkill()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSkill(TblSkills t)
        {
            repository.TAdd(t);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteSkill(int id) 
        {
            var value = repository.Find(x=>x.ID==id);
            repository.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateSkill(int id) 
        {
            var value = repository.Find(x => x.ID == id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateSkill(TblSkills t)
        {
            var value = repository.Find(x => x.ID == t.ID);
            value.Skills = t.Skills;
            value.Percentage =t.Percentage;
            repository.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}