﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LonghornCinemaProject.DAL;
using LonghornCinemaProject.Models;

namespace LonghornCinemaProject.Controllers
{
    public class OrdersController : Controller
    {
        private AppDbContext db = new AppDbContext();

        // GET: Orders
        public ActionResult Index()
        {
            return View(db.Orders.ToList());
        }

        // GET: Orders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // GET: Orders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OrderID,OrderNumber,OrderDate,Notes")] Order order)
        {
            //Find next order number
            order.OrderNumber = Utilities.GenerateOrderNumber.GetNextOrderNumber();

            //Record date of Order
            order.OrderDate = DateTime.Today;


            if (ModelState.IsValid)
            {
                db.Orders.Add(order);
                db.SaveChanges();
                return RedirectToAction("AddToOrder", new { OrderID = order.OrderID });
            }

            return View(order);
        }

        // GET: Orders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        public ActionResult AddToOrder(int OrderID)
        {
            //Create a new instance of the Order detail class
            Ticket t = new Ticket();

            //Find the Order for this order detail
            Order ord = db.Orders.Find(OrderID);

            //Set the new Order detail's Order to the new ord we just found
            t.Order = ord;

            //Populate the view bag with the list of Movies
            ViewBag.AllShowtimes = GetAllShowtimes();

            //Give the view the Order detail object we just created
            return View(t);
        }

        [HttpPost]
        public ActionResult AddToOrder(Ticket t, int SelectedShowtime)
        {
            //Find the product associated with the int SelectedCourse
            Showtime showtime = db.Showtimes.Find(SelectedShowtime);

            //set the product property of the order detail to this newly found product
            t.Showtime = showtime;

            //Find the order associated with the order detail
            Order ord = db.Orders.Find(t.Order.OrderID);

            //set the property of the order detail to this newly found order
            t.Order = ord;

            //set the value of the product fee
            t.TicketPrice = showtime.Price;


            if (ModelState.IsValid)//model meets all requirements
            {
                //add the order detail to the database
                db.Tickets.Add(t);
                db.SaveChanges();
                return RedirectToAction("Details", "Orders", new { id = ord.OrderID });
            }

            //model state is not valid
            ViewBag.AllShowtimes = GetAllShowtimes();
            return View(t);

        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OrderID,TicketID,CustomerID,Email,CreditCard,PopcornPoints")] Order order)
        {
            if (ModelState.IsValid)
            {
                db.Entry(order).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(order);
        }

        public ActionResult RemoveFromOrder(int OrderID)
        {
            Order ord = db.Orders.Find(OrderID);

            if (ord == null)//order is not found
            {
                return RedirectToAction("Details", new { id = OrderID });
            }

            if (ord.Tickets.Count == 0) // there are no order details
            {
                return RedirectToAction("Details", new { id = OrderID });
            }

            //pass the list of order details to the view
            return View(ord.Tickets);
        }

        // GET: Orders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Order order = db.Orders.Find(id);
            db.Orders.Remove(order);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public SelectList GetAllShowtimes()
        {
            //Get the list of Products in order by Products name
            List<Showtime> allShowtimes = db.Showtimes.OrderBy(s => s.ShowtimeTime).ToList();

            //convert the list to a select list
            SelectList selShowtimes = new SelectList(allShowtimes, "ShowtimeID", "Showtime Time");

            //return the select list
            return selShowtimes;

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
