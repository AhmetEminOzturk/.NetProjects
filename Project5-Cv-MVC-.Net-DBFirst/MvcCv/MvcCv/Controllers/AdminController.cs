using MvcCv.Models.Entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{   
    public class AdminController : Controller
    {
        GenericRepository<TblAdmin> repository = new GenericRepository<TblAdmin>();
        public ActionResult Index()
        {
            var values = repository.TGetList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddAdmin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAdmin(TblAdmin tblAdmin)
        {
            repository.TAdd(tblAdmin);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteAdmin(int id)
        {
            TblAdmin tblAdmin = repository.Find(x => x.ID == id);
            repository.TDelete(tblAdmin);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateAdmin(int id)
        {
            TblAdmin tblAdmin = repository.Find(x => x.ID == id);
            return View(tblAdmin);
        }
        [HttpPost]
        public ActionResult UpdateAdmin(TblAdmin tblAdmin)
        {
            TblAdmin t = repository.Find(x => x.ID == tblAdmin.ID);
            t.UserName = tblAdmin.UserName;
            t.Password = tblAdmin.Password;
            repository.TUpdate(t);
            return RedirectToAction("Index");
        }

    }
}