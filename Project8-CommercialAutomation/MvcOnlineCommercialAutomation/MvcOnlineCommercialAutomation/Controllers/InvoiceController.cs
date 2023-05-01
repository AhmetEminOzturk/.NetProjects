
using MvcOnlineCommercialAutomation.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOnlineCommercialAutomation.Controllers
{
    public class InvoiceController : Controller
    {

        // GET: Invoice
        Context c = new Context();
        public ActionResult Index()
        {
            var values = c.Invoices.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddInvoice()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddInvoice(Invoice ınvoice)
        {
            c.Invoices.Add(ınvoice);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateInvoice(int id)
        {
            var values = c.Invoices.Find(id);
            return View("UpdateInvoice", values);
        }
        [HttpPost]
        public ActionResult UpdateInvoice(Invoice invoice)
        {
            var values = c.Invoices.Find(invoice.InvoiceID);
            values.InvoiceSequenceNo = invoice.InvoiceSequenceNo;
            values.InvoiceSerialNo = invoice.InvoiceSerialNo;
            values.Date = invoice.Date;
            values.Time = invoice.Time;
            values.TaxOffice = invoice.TaxOffice;
            values.Deliverer = invoice.Deliverer;
            values.Receiver = invoice.Receiver;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DetailInvoice(int id) 
        {
            var values = c.InvoiceItems.Where(x=> x.InvoiceID == id).ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddInvoiceItem()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddInvoiceItem(InvoiceItem ıtem)
        {
            c.InvoiceItems.Add(ıtem);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}