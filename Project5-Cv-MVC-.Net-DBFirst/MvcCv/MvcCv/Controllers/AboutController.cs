using MvcCv.Models.Entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class AboutController : Controller
    {

        GenericRepository<TblAbout> repository = new GenericRepository<TblAbout>();

        [HttpGet]
        public ActionResult Index()
        {
            var values = repository.TGetList();
            return View(values);
        }

        [HttpPost]
        public ActionResult Index(TblAbout t)
        {
            var values = repository.Find(x => x.ID == 1);
            values.Name= t.Name;
            values.Surname= t.Surname;
            values.Address= t.Address;
            values.Mail= t.Mail;
            values.PhoneNumber= t.PhoneNumber;
            values.Description= t.Description;
            values.Image= t.Image;
            repository.TUpdate(values);
            return RedirectToAction("Index");
        }
    }
}