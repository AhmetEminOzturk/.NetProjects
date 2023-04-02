using MvcCv.Models.Entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class SocialMediaController : Controller
    {
        GenericRepository<TblSocialMedia> repository = new GenericRepository<TblSocialMedia>();
        public ActionResult Index()
        {
            var values = repository.TGetList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddSocialMedia()
        {     
            return View();
        }
        [HttpPost]        
        public ActionResult AddSocialMedia(TblSocialMedia t)
        {
            repository.TAdd(t);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateSocialMedia(int id)
        {
            var value = repository.Find(x=>x.ID== id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateSocialMedia(TblSocialMedia t)
        {
            var value = repository.Find(x => x.ID == t.ID);
            value.Name= t.Name;
            value.Status = true;
            value.Link=t.Link;
            value.Icon=t.Icon;
            repository.TUpdate(value);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteSocialMedia(int id) 
        {
            var value = repository.Find(x => x.ID == id);
            value.Status = false;
            repository.TUpdate(value);
            return RedirectToAction("Index");
        }
    }
}