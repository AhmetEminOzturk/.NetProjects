﻿using MvcCv.Models.Entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class ContactController : Controller
    {
        GenericRepository<TblContact> repository = new GenericRepository<TblContact>();
        public ActionResult Index()
        {
            var values = repository.TGetList();
            return View(values);
        }
    }
}