using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LonghornCinemaProject.Models
{
    public class Showtime
    {
        public Int32 ShowtimeID { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime ShowtimeTime { get; set; }

        public String TheaterNumber { get; set; }

        public List<String> SeatNumbers { get; set; }

        public virtual List<Movie> Movies { get; set; }
    }
}