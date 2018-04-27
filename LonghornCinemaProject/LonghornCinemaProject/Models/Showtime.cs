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

        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal Price { get; set; }

        public virtual Movie Movie { get; set; }

        public virtual List<Ticket> Tickets { get; set; }

        public Showtime()
        {
            if (Movie == null)
            {
                Movie = new Movie();
            }
        }
    }
}