using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TeamProject.DAL;
using TeamProject.Models;

namespace TeamProject.Controllers
{
    public class RequestListsController : Controller
    {
        private TeamProjectCtx db = new TeamProjectCtx();

        // GET: RequestLists
        public ActionResult Index()
        {
            var requestLists = db.RequestLists.Include(r => r.Customer);
            return View(requestLists.ToList());
        }

        // GET: RequestLists/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RequestList requestList = db.RequestLists.Find(id);
            if (requestList == null)
            {
                return HttpNotFound();
            }
            return View(requestList);
        }

        // GET: RequestLists/Create
        public ActionResult Create()
        {
            ViewBag.CustomerID = new SelectList(db.Customers, "CustomerID", "CustomerName");
            return View();
        }

        // POST: RequestLists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RequestId,CustomerID,Brand,Model,ReceivedDate")] RequestList requestList)
        {
            if (ModelState.IsValid)
            {
                db.RequestLists.Add(requestList);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CustomerID = new SelectList(db.Customers, "CustomerID", "CustomerName", requestList.CustomerID);
            return View(requestList);
        }

        // GET: RequestLists/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RequestList requestList = db.RequestLists.Find(id);
            if (requestList == null)
            {
                return HttpNotFound();
            }
            ViewBag.CustomerID = new SelectList(db.Customers, "CustomerID", "CustomerName", requestList.CustomerID);
            return View(requestList);
        }

        // POST: RequestLists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RequestId,CustomerID,Brand,Model,ReceivedDate")] RequestList requestList)
        {
            if (ModelState.IsValid)
            {
                db.Entry(requestList).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CustomerID = new SelectList(db.Customers, "CustomerID", "CustomerName", requestList.CustomerID);
            return View(requestList);
        }

        // GET: RequestLists/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RequestList requestList = db.RequestLists.Find(id);
            if (requestList == null)
            {
                return HttpNotFound();
            }
            return View(requestList);
        }

        // POST: RequestLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RequestList requestList = db.RequestLists.Find(id);
            db.RequestLists.Remove(requestList);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
