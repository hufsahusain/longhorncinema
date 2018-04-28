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
using LonghornCinemaProject.Controllers;

namespace LonghornCinemaProject.Controllers
{
    public class OrdersController : Controller
    {
        public Nullable<DateTime> myDateTime { get; set; }
       
      
    
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
            DateTime time = new DateTime();
           



                order.OrderDate = time;
            

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

            //Populate the view bag with the list of Seats
            ViewBag.AllSeats = GetAllSeats();

            //Give the view the Order detail object we just created
            return View(t);
        }

        [HttpPost]
        public ActionResult AddToOrder(Ticket t, int SelectedShowtime, int[] SelectedSeats)
        {
            Order ord = new Order();

            foreach (int i in SelectedSeats)
            {
                Ticket tick = new Ticket();

                tick.Seat.SeatName = GetSeatName(i);
                tick.Seat.SeatID = i;
              

            }

            //Find the product associated with the int SelectedCourse
            Showtime showtime = db.Showtimes.Find(SelectedShowtime);

            //set the product property of the order detail to this newly found product
            t.Showtime = showtime;

            //Find the order associated with the order detail
             ord = db.Orders.Find(t.Order.OrderID);

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
            SelectList selShowtimes = new SelectList(allShowtimes, "ShowtimeID", "ShowtimeTime");

            //return the select list
            return selShowtimes;

        }

        public MultiSelectList FindAvailableSeats(List<Ticket> tickets) //tickets is the list of 
        {
            List<Seat> TakenSeats = new List<Seat>();

            foreach (Ticket t in tickets)
            {
                Seat s = new Seat();
                s.SeatName = GetSeatName(s.SeatID);
                s.SeatID = GetSeatID(s.SeatName);
                TakenSeats.Add(s);
            }

            List<Seat> AvailableSeats = GetAllSeats().Except(TakenSeats).ToList();

            MultiSelectList slAvailableSeats = new MultiSelectList(AvailableSeats, "SeatID", "SeatName");

            return slAvailableSeats;

        }

        public List<Seat> GetAllSeats()
        {
            List<Seat> AllSeats = new List<Seat>();

            Seat s1 = new Seat() { SeatID = 0, SeatName = "1A" };
            AllSeats.Add(s1);

            Seat s2 = new Seat() { SeatID = 0, SeatName = "1B" };
            AllSeats.Add(s2);

            Seat s3 = new Seat() { SeatID = 0, SeatName = "1C" };
            AllSeats.Add(s3);

            Seat s4 = new Seat() { SeatID = 0, SeatName = "1D" };
            AllSeats.Add(s4);

            Seat s5 = new Seat() { SeatID = 0, SeatName = "2A" };
            AllSeats.Add(s5);

            Seat s6 = new Seat() { SeatID = 0, SeatName = "2B" };
            AllSeats.Add(s6);

            Seat s7 = new Seat() { SeatID = 0, SeatName = "2C" };
            AllSeats.Add(s7);

            Seat s8 = new Seat() { SeatID = 0, SeatName = "2D" };
            AllSeats.Add(s8);

            Seat s9 = new Seat() { SeatID = 0, SeatName = "3B" };
            AllSeats.Add(s9);

            Seat s10 = new Seat() { SeatID = 0, SeatName = "3C" };
            AllSeats.Add(s10);

            Seat s11 = new Seat() { SeatID = 0, SeatName = "3D" };
            AllSeats.Add(s11);

            Seat s12 = new Seat() { SeatID = 0, SeatName = "4A" };
            AllSeats.Add(s12);

            Seat s13 = new Seat() { SeatID = 0, SeatName = "4B" };
            AllSeats.Add(s13);

            Seat s14 = new Seat() { SeatID = 0, SeatName = "4C" };
            AllSeats.Add(s14);

            Seat s15 = new Seat() { SeatID = 0, SeatName = "4D" };
            AllSeats.Add(s15);

            Seat s16 = new Seat() { SeatID = 0, SeatName = "5A" };
            AllSeats.Add(s16);

            Seat s17 = new Seat() { SeatID = 0, SeatName = "5B" };
            AllSeats.Add(s17);

            Seat s18 = new Seat() { SeatID = 0, SeatName = "5C" };
            AllSeats.Add(s18);

            Seat s19 = new Seat() { SeatID = 0, SeatName = "5D" };
            AllSeats.Add(s19);

            Seat s20 = new Seat() { SeatID = 0, SeatName = "6A" };
            AllSeats.Add(s20);

            Seat s21 = new Seat() { SeatID = 0, SeatName = "6B" };
            AllSeats.Add(s21);

            Seat s22 = new Seat() { SeatID = 0, SeatName = "6C" };
            AllSeats.Add(s22);

            Seat s23 = new Seat() { SeatID = 0, SeatName = "6D" };
            AllSeats.Add(s23);

            Seat s24 = new Seat() { SeatID = 0, SeatName = "7A" };
            AllSeats.Add(s24);

            Seat s25 = new Seat() { SeatID = 0, SeatName = "7B" };
            AllSeats.Add(s25);

            Seat s26 = new Seat() { SeatID = 0, SeatName = "7C" };
            AllSeats.Add(s26);

            Seat s27 = new Seat() { SeatID = 0, SeatName = "7D" };
            AllSeats.Add(s27);

            Seat s28 = new Seat() { SeatID = 0, SeatName = "8A" };
            AllSeats.Add(s28);

            Seat s29 = new Seat() { SeatID = 0, SeatName = "8B" };
            AllSeats.Add(s29);

            Seat s30 = new Seat() { SeatID = 0, SeatName = "8C" };
            AllSeats.Add(s30);

            Seat s31 = new Seat() { SeatID = 0, SeatName = "8D" };
            AllSeats.Add(s31);

            return AllSeats;
        }

        public Int32 GetSeatID(String seatName)
        {
            if (seatName == "1A") return 0;
            if (seatName == "1B") return 1;
            if (seatName == "1C") return 2;
            if (seatName == "1D") return 3;
            if (seatName == "2A") return 4;
            if (seatName == "2B") return 5;
            if (seatName == "2C") return 6;
            if (seatName == "2D") return 7;
            if (seatName == "3A") return 8;
            if (seatName == "3B") return 9;
            if (seatName == "3C") return 10;
            if (seatName == "3D") return 11;
            if (seatName == "4A") return 12;
            if (seatName == "4B") return 13;
            if (seatName == "4C") return 14;
            if (seatName == "4D") return 15;
            if (seatName == "5A") return 16;
            if (seatName == "5B") return 17;
            if (seatName == "5C") return 18;
            if (seatName == "5D") return 19;
            if (seatName == "6A") return 20;
            if (seatName == "6B") return 21;
            if (seatName == "6C") return 22;
            if (seatName == "6D") return 23;
            if (seatName == "7A") return 24;
            if (seatName == "7B") return 25;
            if (seatName == "7C") return 26;
            if (seatName == "7D") return 27;
            if (seatName == "8A") return 28;
            if (seatName == "8B") return 29;
            if (seatName == "8C") return 30;
            if (seatName == "8D") return 31;

            else
            {
                return 100;
            }
        }

        public String GetSeatName(Int32 seatID)
        {
            if (seatID == 0) return "1A";
            if (seatID == 2) return "1B";
            if (seatID == 3) return "1C";
            if (seatID == 4) return "1D";
            if (seatID == 5) return "2A";
            if (seatID == 6) return "2B";
            if (seatID == 7) return "2C";
            if (seatID == 8) return "2D";
            if (seatID == 9) return "3A";
            if (seatID == 10) return "3B";
            if (seatID == 11) return "3C";
            if (seatID == 12) return "3D";
            if (seatID == 13) return "4A";
            if (seatID == 14) return "4B";
            if (seatID == 15) return "4C";
            if (seatID == 16) return "4D";
            if (seatID == 17) return "5A";
            if (seatID == 18) return "5B";
            if (seatID == 19) return "5C";
            if (seatID == 20) return "5D";
            if (seatID == 21) return "6A";
            if (seatID == 22) return "6B";
            if (seatID == 23) return "6C";
            if (seatID == 24) return "6D";
            if (seatID == 25) return "7A";
            if (seatID == 26) return "7B";
            if (seatID == 27) return "7C";
            if (seatID == 28) return "7D";
            if (seatID == 29) return "8A";
            if (seatID == 30) return "8B";
            if (seatID == 31) return "8C";
            if (seatID == 32) return "8D";

            else
            {
                return "n/a";
            }
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
