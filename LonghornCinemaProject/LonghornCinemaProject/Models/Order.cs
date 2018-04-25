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

        [Display(Name = "Order ID")]
        public Int32 OrderID { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Order Date")]
        [DisplayFormat(DataFormatString = "{0:dd/mm/yyyy}",
                                            ApplyFormatInEditMode = true)]
        public DateTime OrderDate { get; set; }

        //Nav property for Customer
        public virtual Customer Customer { get; set; }

        //Nav property for Tickets
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }


}