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

        public ActionResult InboxMessage()
        {
            var mail = (string)Session["CurrentAccountMail"];
            var values = c.Messages.Where(x=> x.Receiver == mail).OrderByDescending(x=> x.MessagejID).ToList();
            var ınbox = c.Messages.Count(x => x.Receiver == mail).ToString();
            var outbox = c.Messages.Count(x => x.Sender == mail).ToString();
            ViewBag.d2 = outbox;
            ViewBag.d1 = ınbox;

            return View(values);
        }
        public ActionResult OutboxMessage()
        {
            var mail = (string)Session["CurrentAccountMail"];
            var values = c.Messages.Where(x => x.Sender == mail).OrderByDescending(x=>x.MessagejID).ToList();
            var outbox = c.Messages.Count(x => x.Sender == mail).ToString();
            var ınbox = c.Messages.Count(x => x.Receiver == mail).ToString();
            ViewBag.d1 = ınbox;
            ViewBag.d2 = outbox;

            return View(values);
        }
        public ActionResult MessageDetail(int id)
        {
            var values = c.Messages.Where(x=> x.MessagejID == id).ToList();
            var mail = (string)Session["CurrentAccountMail"];
            var outbox = c.Messages.Count(x => x.Sender == mail).ToString();
            var ınbox = c.Messages.Count(x => x.Receiver == mail).ToString();
            ViewBag.d1 = ınbox;
            ViewBag.d2 = outbox;
            return View(values);
        }

        [HttpGet]
        public ActionResult NewMessage()
        {
            var mail = (string)Session["CurrentAccountMail"];
            var outbox = c.Messages.Count(x => x.Sender == mail).ToString();
            var ınbox = c.Messages.Count(x => x.Receiver == mail).ToString();
            ViewBag.d1 = ınbox;
            ViewBag.d2 = outbox;
            return View();
        }
        [HttpPost]
        public ActionResult NewMessage(Message message)
        {
            var mail = (string)Session["CurrentAccountMail"];
            message.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            message.Sender = mail;
            c.Messages.Add(message);
            c.SaveChanges();
            return View();
        }
    }
}