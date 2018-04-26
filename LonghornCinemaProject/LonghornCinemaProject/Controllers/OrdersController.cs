using System;
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
            OrderDetail od = new OrderDetail();

            //Find the Order for this order detail
            Order ord = db.Orders.Find(OrderID);

            //Set the new Order detail's Order to the new ord we just found
            od.Order = ord;

            //Populate the view bag with the list of Movies
            ViewBag.AllTickets = GetAllTickets();

            //Give the view the Order detail object we just created
            return View(od);
        }

        [HttpPost]
        public ActionResult AddToOrder(OrderDetail od, int SelectedTicket)
        {
            //Find the product associated with the int SelectedCourse
            Ticket ticket = db.Tickets.Find(SelectedTicket);

            //set the product property of the order detail to this newly found product
            od.Ticket = ticket;

            //Find the order associated with the order detail
            Order ord = db.Orders.Find(od.Order.OrderID);

            //set the property of the order detail to this newly found order
            od.Order = ord;

            //set the value of the product fee
            od.TicketPrice = ticket.Price;

            //set the value of the total fees???

            if (ModelState.IsValid)//model meets all requirements
            {
                //add the order detail to the database
                db.OrderDetails.Add(od);
                db.SaveChanges();
                return RedirectToAction("Details", "Orders", new { id = ord.OrderID });
            }

            //model state is not valid
            ViewBag.AllTickets = GetAllTickets();
            return View(od);

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

        public SelectList GetAllTickets()
        {
            //Get the list of Products in order by Products name
            List<Ticket> allTickets = db.Tickets.OrderBy(t => t.TicketID).ToList();

            //convert the list to a select list
            SelectList selTickets = new SelectList(allTickets, "TicketID", "Title");

            //return the select list
            return selTickets;

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
