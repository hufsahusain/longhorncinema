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
        public Int32 TicketID { get; set; }

        //Ticket Price
        public Decimal Price { get;  set; }

        //Nav Property for Seat
        public virtual Seat Seat { get; set; }

        //Nav Property for Order
        public virtual List<OrderDetail> OrderDetails { get; set; }

        //Nav Property for Movies
        public virtual List<Movie> Movies { get; set; }





    }
}