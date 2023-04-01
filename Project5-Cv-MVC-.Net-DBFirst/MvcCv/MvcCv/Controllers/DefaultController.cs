using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;

namespace MvcCv.Controllers
{
    public class DefaultController : Controller
    {
       DbCvEntities db = new DbCvEntities();

        public ActionResult Index()
        {
            var values = db.TblAbout.ToList();
            return View(values);
        }
        public PartialViewResult Experience()
        {
            var values = db.TblExperiences.ToList();
            return PartialView(values);
        }
        public PartialViewResult Education()
        {
            var values = db.TblEducation.ToList();
            return PartialView(values);
        }
        public PartialViewResult Skills()
        {
            var values = db.TblSkills.ToList();
            return PartialView(values);
        }
        public PartialViewResult Hobbies()
        {
            var values = db.TblHobbies.ToList();
            return PartialView(values);
        }
        public PartialViewResult Certificates()
        {
            var values = db.TblCertificates.ToList();
            return PartialView(values);
        }

        [HttpGet]
        public PartialViewResult Contact()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult Contact(TblContact tblContact)
        {
            tblContact.Date=DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TblContact.Add(tblContact);
            db.SaveChanges();
            return PartialView();
        }
    }
}