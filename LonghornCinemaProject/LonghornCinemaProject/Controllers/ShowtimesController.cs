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
    public enum TheaterNumber {One, Two};

    public class ShowtimesController : Controller
    {

        private AppDbContext db = new AppDbContext();

        // GET: Showtimes
        public ActionResult Index()
        {
            return View(db.Showtimes.ToList());
        }

        // GET: Showtimes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Showtime showtime = db.Showtimes.Find(id);
            if (showtime == null)
            {
                return HttpNotFound();
            }
            return View(showtime);
        }

        // GET: Showtimes/Create
        public ActionResult Create()
        {
            ViewBag.AllMovies = GetAllMovies();
            return View();
        }

        public SelectList GetAllMovies()
        {
            //Get the list of Products in order by Products name
            List<Movie> allMovies = db.Movies.OrderBy(p => p.Title).ToList();

            //convert the list to a select list
            SelectList selMovies = new SelectList(allMovies, "MovieID", "Title");

            //return the select list
            return selMovies;

        }

        public SelectList GetAllMovies(Showtime showtime)
        {
            List<Movie> allMovies = db.Movies.OrderBy(m => m.Title).ToList();

            ////convert list of selected departments to ints
            //List<Int32> SelectedMovies = new List<Int32>();

            ////loop through the showtime's movies and add the movie id
            //foreach (Movie mov in showtime.Movies)
            //{
            //    SelectedMovies.Add(mov.MovieID);
            //}

            //create the multiselect list
            SelectList selMovies = new SelectList(allMovies, "MovieID", "Title");

            //return the multiselect list
            return selMovies;

        }


        // POST: Showtimes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ShowtimeID,ShowtimeTime,TheaterNumber")] Showtime showtime, int SelectedMovies)
        {
            //add Movies
            
            //find the vendor
            Movie mov = db.Movies.Find(SelectedMovies);
            showtime.Movies.Add(mov);

            //add vendors
            //foreach (int i in SelectedMovies)
            //{
            //    //find the vendor
            //    Movie mvie = db.Movies.Find(i);
            //    showtime.Movies.Add(mvie);
            //}

            if (ModelState.IsValid)
            {
                db.Showtimes.Add(showtime);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            //Populate the view bag with the department list
            //ViewBag.AllMovies = GetAllMovies(showtime);
            return View(showtime);
        }

        // GET: Showtimes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Showtime showtime = db.Showtimes.Find(id);
            if (showtime == null)
            {
                return HttpNotFound();
            }
            return View(showtime);
        }

        // POST: Showtimes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ShowtimeID,ShowtimeTime,TheaterNumber")] Showtime showtime)
        {
            if (ModelState.IsValid)
            {
                db.Entry(showtime).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(showtime);
        }

        // GET: Showtimes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Showtime showtime = db.Showtimes.Find(id);
            if (showtime == null)
            {
                return HttpNotFound();
            }
            return View(showtime);
        }

        // POST: Showtimes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Showtime showtime = db.Showtimes.Find(id);
            db.Showtimes.Remove(showtime);
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
