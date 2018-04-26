using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace LonghornCinemaProject.Models
{
    public class OrderDetail
    {
        //OrderDetail ID
        [Display(Name = "OrderDetail ID")]
        public Int32 OrderDetailID { get; set; }

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

        //Navigational Property with Order (One-Many)
        public virtual Order Order { get; set; }

        //Navigational Property with Product (One-Many)
        public virtual Ticket Ticket { get; set; }
    }
}