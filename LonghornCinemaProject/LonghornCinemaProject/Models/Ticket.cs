using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LonghornCinemaProject.Models
{
    public class Ticket
    {
        //Ticket ID
        [Display(Name = "Ticket ID")]
        public Int32 TicketID { get; set; }

        //Quantity
        [Display(Name = "Quantity")]
        public Int32 Quantity { get; set; }

        //Product Price
        [Display(Name = "Ticket Price")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal TicketPrice { get; set; }

        //Extended Price
        [Display(Name = "Extended Price")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal ExtendedPrice
        {
            get { return TicketPrice * Quantity; }
        }

        //Nav Property for Seat
        public virtual Seat Seat { get; set; }

        //Nav Property for Movies
        public virtual List<Movie> Movies { get; set; }

        //Nav Property for Showtimes
        public virtual Showtime Showtime { get; set; }

        //Nav Property for Orders
        public virtual Order Order { get; set; }






    }
}