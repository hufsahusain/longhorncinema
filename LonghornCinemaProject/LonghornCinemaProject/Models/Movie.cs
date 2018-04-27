using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LonghornCinemaProject.Models
{
    //MovieID (PK)
    //Genre
    //ReleaseYear
    //MPAARating
    //Tagline
    //CustomerRating
    //Actors
    //Title
    //ShowtimeIDList(ShowtimeIDs (FK))
    //RunningTime

        public class Movie
        {
            // Primary Key
            [Required(ErrorMessage = "Movie ID is required")]
            [Display(Name = "Movie ID")]
            public Int32 MovieID { get; set; }

            [Display(Name = "Genres")]
            public virtual List<Genre> Genres { get; set; }

            [DataType(DataType.Date, ErrorMessage = "Please enter a valid year of release")]
            [Display(Name = "Release Date")]
            [DisplayFormat(DataFormatString = "{0:mm/dd/yyyy}", ApplyFormatInEditMode = true)]
            public DateTime ReleaseDate { get; set; }

            [Display(Name = "MPAA Rating")]
            public String Rating { get; set; }

            [Display(Name = "Tagline")]
            public String Tagline { get; set; }

            [Display(Name = "Customer Rating")]
            public Decimal MovieCustomerRating { get; set; }

            [Display(Name = "Actors")]
            public String Actors { get; set; }

            [Display(Name = "Title")]
            public String Title { get; set; }

            [Display(Name = "Runtime")]
            public Int32 RunTime { get; set; }

            [Display(Name = "Overview")]
            public String Overview { get; set; }

            [Display(Name = "Revenue")]
            public Int64 Revenue { get; set; }

            // Navigational Properties
            public virtual List<Showtime> Showtimes { get; set; }

            public Movie()
            {
                if (Showtimes == null)
                {
                    Showtimes = new List<Showtime>();
                }
            }
    }














    }
