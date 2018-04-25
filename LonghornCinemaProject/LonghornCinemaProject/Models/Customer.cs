using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace LonghornCinemaProject.Models
{
    public class Customer
    {
        // Customer ID | Primary Key
        public Int32 CustomerID { get; set; }

        // Email 
        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }

        // Password
        public String Password { get; set; }

        //First Name
        public String FirstName { get; set; }

        //Last Name
        public String LastName { get; set; }

        //Address
        public String Address { get; set; }

        //Phone Number
        [DataType(DataType.PhoneNumber)]
        public Int32 PhoneNumber { get; set; }

        //BirthDate
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        //Credit Card
        [DisplayFormat(DataFormatString = "{0:####-####-####-####}",
            ApplyFormatInEditMode = true)]

        public Int32 CreditCard { get; set; }

        //Popcorn Points 
        public Int32 PopcornPoints { get; set; }

        //Nav Property for Order
        public virtual List<Order> Orders { get; set; }





    }
}