using MvcOnlineCommercialAutomation.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOnlineCommercialAutomation.Controllers
{
    public class CurrentAccountPanelController : Controller
    {
        // GET: CurrentAccountPanel
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var mail = (string)Session["CurrentAccountMail"];
            var values = c.CurrentAccounts.FirstOrDefault(x=> x.CurrentAccountMail == mail);
            return View(values);
        }
        public ActionResult Order()
        {
            var mail = (string)Session["CurrentAccountMail"];
            var id = c.CurrentAccounts.Where(x=> x.CurrentAccountMail == mail).Select(y=> y.CurrentAccountID).FirstOrDefault();
            var values = c.SaleTransactions.Where(x => x.CurrentAccountID == id).ToList();
            return View(values);
        }
    }
}