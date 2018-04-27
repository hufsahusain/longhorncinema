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
        private const Decimal SALES_TAX = 0.0825m;

        //Order ID
        [Display(Name = "Order ID")]
        public Int32 OrderID { get; set; }

        //Order Number
        [Display(Name = "Order Number")]
        public Int32 OrderNumber { get; set; }

        //Order Date
        [DataType(DataType.Date)]
        [Display(Name = "Order Date")]
        [DisplayFormat(DataFormatString = "{0:dd/mm/yyyy}",
                                            ApplyFormatInEditMode = true)]
        public DateTime OrderDate { get; set; }

        //Notes
        [Display(Name = "Notes")]
        public string Notes { get; set; }

        //Order Subtotal
        [Display(Name = "Order Subtotal")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public Decimal OrderSubtotal
        {
            get { return Tickets.Sum(t => t.ExtendedPrice); }
        }

        //Sales Tax
        [Display(Name = "Sales Tax (8.25%)")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public Decimal SalesTax
        {
            get { return OrderSubtotal * SALES_TAX; }
        }

        [Display(Name = "Order Total")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public Decimal OrderTotal
        {
            get { return OrderSubtotal + SalesTax; }
        }

        //Nav property for Customer
        public virtual Customer Customer { get; set; }

        //Nav property for Tickets
        public virtual List<Ticket> Tickets { get; set; }

        public Order()
        {
            if (Tickets == null)
            {
                Tickets = new List<Ticket>();
            }
        }
    }


}