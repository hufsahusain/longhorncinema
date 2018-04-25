using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LonghornCinemaProject.DAL;
using LonghornCinemaProject.Models;

namespace LonghornCinemaProject.Controllers
{
   //TODO: Create multiselectbox for MPAARating
   //This is a comment
   //hello from Katie
    public enum MPAARating { G, PG, PG13, R, Unrated, All }

    // create enum
    public enum Comparison { Greater, Less }


    public class HomeController : Controller
    {
        //Create an instance of the db context
        AppDbContext db = new AppDbContext();

        //public ActionResult Index()
        //{
        //    return View(db.Movies.ToList());
        //}

        // GET: Home
        public ActionResult DetailedSearch()
        {
            //ViewBag.AllGenres = GetAllGenres;
            return View();
            
        }

        //Create action to return search results/query to be displayed to the index
        public ActionResult DisplaySearchResults(String strTitle, String TagLine, String ReleaseYear, Comparison ?SelectedComparison, MPAARating ?SelectedRating, String SelectedActors)/*, int[] SelectedGenre, , , , String StrCustomerRating, )*/
        {
            // create list of repositories
            List<Movie> SelectedMovies = new List<Movie>();

            //create query
            var query = from r in db.Movies
                        select r;

            //Title Search
            if (strTitle != null)
            {
                //if they select a search string, limit results to only repos meeting criteria
                query = query.Where(r => r.Title.Contains(strTitle));
            }

            //Tagline Search
            if (TagLine != null)
            {
                //if they select a search string, limit results to only repos meeting criteria
                query = query.Where(r => r.Tagline.Contains(TagLine));
            }

            ////Genres Search


            //release year search (greater or less)
            switch (SelectedComparison)
            {
                case Comparison.Greater:
                    if (ReleaseYear != null)
                    {
                        int intReleaseYear;
                        try
                        {
                            intReleaseYear = Convert.ToInt32(ReleaseYear);
                            query = query.Where(r => r.ReleaseDate.Year >= (intReleaseYear));
                        }
                        catch
                        {
                            return View("DetailedSearch");
                        }
                    }

                    break;

                case Comparison.Less:
                    if (ReleaseYear != null)
                    {
                        int intReleaseYear;
                        try
                        {
                            intReleaseYear = Convert.ToInt32(ReleaseYear);
                            query = query.Where(r => r.ReleaseDate.Year <= (intReleaseYear));
                        }
                        catch
                        {
                            return View("DetailedSearch");
                        }
                    }
                    break;

            }



            //        // create query for entries modified after inputted date


            // create queries for mpaa rating
            switch (SelectedRating)
            {
                case MPAARating.G:
                    query = query.Where(r => r.Rating.Equals("G"));
                    break;
                case MPAARating.PG:
                    query = query.Where(r => r.Rating.Equals("PG"));
                    break;
                case MPAARating.PG13:
                    query = query.Where(r => r.Rating.Equals("PG-13"));
                    break;
                case MPAARating.R:
                    query = query.Where(r => r.Rating.Equals("R"));
                    break;
                case MPAARating.Unrated:
                    query = query.Where(r => r.Rating.Equals("Unrated"));
                    break;
                case MPAARating.All:
                    query = query.Where(r => r.Rating.Equals("G") || r.Rating.Equals("PG") || r.Rating.Equals("PG-13") || r.Rating.Equals("R") || r.Rating.Equals("Unrated"));
                    break;

            }

            ////create query for customer rating
            ////Need seed data
            ////Adjust queries for average of MovieCustomerRatings
            //switch (SelectedComparison)
            //{
            //    case Comparison.Greater:
            //        if (StrCustomerRating != null)
            //        {
            //            decimal decCustomerRating;
            //            try
            //            {
            //                decCustomerRating = Convert.ToDecimal(StrCustomerRating);
            //                query = query.Where(r => r.MovieCustomerRating >= (decCustomerRating));
            //            }
            //            catch
            //            {
            //                return View();
            //            }
            //        }

            //        break;

            //    case Comparison.Less:
            //        if (StrCustomerRating != null)
            //        {
            //            decimal decNumberOfStars;
            //            try
            //            {
            //                decNumberOfStars = Convert.ToDecimal(StrCustomerRating);
            //                query = query.Where(r => r.MovieCustomerRating >= (decNumberOfStars));
            //            }
            //            catch
            //            {
            //                return View();
            //            }
            //        }

            //        break;
            //}

            //Actors Search
            if (SelectedActors != null)
            {
                //if they select a search string, limit results to only repos meeting criteria
                query = query.Where(r => r.Actors.Contains(SelectedActors));
            }

            //execute query
            SelectedMovies = query.ToList();

      
            //repository Count
            ViewBag.TotalRepositories = db.Movies.Count();
            ViewBag.SelectedRepositories = SelectedMovies.Count();

            //order list
            SelectedMovies.OrderByDescending(m => m.ReleaseDate);

            //send list to view
            return View("Index", SelectedMovies);
            
        }


        //Genre Search **Add table**

        public MultiSelectList GetAllGenres()
        {

            List<Genre> allGenres = db.Genres.OrderBy(g => g.GenreName).ToList();

            MultiSelectList selGenres = new MultiSelectList(allGenres, "GenreID", "Name");

            return selGenres;
        }


        public MultiSelectList GetAllGenres(Movie movie)
        {
            List<Genre> allGenres = db.Genres.OrderBy(g => g.GenreName).ToList();

            //convert list of selected departments to ints
            List<Int32> SelectedGenres = new List<Int32>();

            //loop through the course's departments and add the department id
            foreach (Genre gen in movie.Genres)
            {
                SelectedGenres.Add(gen.GenreID);
            }

            //create the multiselect list
            MultiSelectList selGenres = new MultiSelectList(allGenres, "GenreID", "Name", SelectedGenres);

            //return the multiselect list
            return selGenres;
        }



        public ActionResult Index(String strTitle)
        {
                List<Movie> SelectedMovies = new List<Movie>();

                //create query
                var query = from r in db.Movies
                            select r;

                if (strTitle != null)
                {
                    //if they select a search string, limit results to only repos meeting criteria
                    query = query.Where(r => r.Title.Contains(strTitle));

                }

                //execute query
                SelectedMovies = query.ToList();


                //repository Count
                ViewBag.TotalRepositories = db.Movies.Count();
                ViewBag.SelectedRepositories = SelectedMovies.Count();

                //order list
                SelectedMovies.OrderByDescending(r => r.ReleaseDate);

                //send list to view
                return View(SelectedMovies);
        }



    }




}