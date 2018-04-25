using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

//
namespace LonghornCinemaProject.Models
{
    public class Order
    {

        public Int32 OrderID { get; set; }

        //Nav property for Customer
        public virtual Customer Customer { get; set; }

        //Nav property for Tickets
        public virtual List<Ticket> Tickets { get; set; }
    }


}