using MvcCv.Models.Entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceRepository experienceRepository = new ExperienceRepository();
        public ActionResult Index()
        {
            var values = experienceRepository.TGetList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddExperience()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddExperience(TblExperiences tblExperiences)
        {
            experienceRepository.TAdd(tblExperiences);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteExperience(int id) 
        {
            TblExperiences tblExperiences = experienceRepository.Find(x=> x.ID== id);
            experienceRepository.TDelete(tblExperiences);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult GetExperience(int id)
        {
            TblExperiences tblExperiences = experienceRepository.Find(x => x.ID == id);
            return View(tblExperiences);
        }
        [HttpPost]
        public ActionResult GetExperience(TblExperiences tblExperiences)
        {
            TblExperiences t = experienceRepository.Find(x => x.ID == tblExperiences.ID);
            t.Title= tblExperiences.Title;
            t.Subtitle= tblExperiences.Subtitle;
            t.Date= tblExperiences.Date;
            t.Description= tblExperiences.Description;
            experienceRepository.TUpdate(t);
            return RedirectToAction("Index");
        }



    }
}