using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace AgriculturePresentation.ViewComponents
{
    public class _DashboardOverviewPartial:ViewComponent
    {
        AgricultureContext c = new AgricultureContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.teamCount = c.Employees.Count();
            ViewBag.serviceCount = c.Services.Count();
            ViewBag.messageCount = c.Contacts.Count();
            ViewBag.currentMonthMessage = c.Contacts.Where(x => x.Date.Month == DateTime.Now.Month).Count();

            ViewBag.announcementTrue = c.Announcements.Where(x => x.Status == true).Count();
            ViewBag.announcementFalse = c.Announcements.Where(x => x.Status == false).Count();

            ViewBag.urunPazarlama = c.Employees.Where(x => x.Title == "Ürün Pazarlama").Select(y => y.EmployeeName).FirstOrDefault();
            ViewBag.bakliyatYonetimi = c.Employees.Where(x => x.Title == "Bakliyat Yönetimi").Select(y => y.EmployeeName).FirstOrDefault();
            ViewBag.sutUretici = c.Employees.Where(x => x.Title == "Süt Üreticisi").Select(y => y.EmployeeName).FirstOrDefault();
            ViewBag.gubreYonetimi = c.Employees.Where(x => x.Title == "Gübre Yönetimi").Select(y => y.EmployeeName).FirstOrDefault();
            return View();
        }
    }
}
