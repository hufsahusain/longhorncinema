﻿using System;
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
        public Decimal TicketPrice { get;  set; }


        //Nav Property for Order
        public virtual Order Order { get; set; }

        //Nav Property for Seat
        public virtual Seat Seat { get; set; }





    }
}