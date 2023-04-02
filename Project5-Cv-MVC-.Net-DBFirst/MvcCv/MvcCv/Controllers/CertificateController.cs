using MvcCv.Models.Entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class CertificateController : Controller
    {
        GenericRepository<TblCertificates> repository = new GenericRepository<TblCertificates>(); 
        public ActionResult Index()
        {
            var values = repository.TGetList();
            return View(values);
        }

        [HttpGet]
        public ActionResult UpdateCertificate(int id) 
        {
            var value = repository.Find(x=>x.ID== id);
            ViewBag.id=id;
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateCertificate(TblCertificates t)
        {
            var value = repository.Find(x => x.ID == t.ID);
            value.Description = t.Description;
            value.Date= t.Date;
            repository.TUpdate(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddCertificate()
        {         
            return View();
        }
        [HttpPost]
        public ActionResult AddCertificate(TblCertificates t)
        {
            repository.TAdd(t);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteCertificate(int id)
        {
            var value = repository.Find(x => x.ID == id);
            repository.TDelete(value);
            return RedirectToAction("Index");
        }


    }
}