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

        //Middle Initial 
        public String MiddleInitial { get; set; }

        //Last Name
        public String LastName { get; set; }

        //Address pt 1
        public String City { get; set; }

        //Address pt 2
        public String State { get; set; }

        //Address pt 3
        public String Street { get; set; }

        //Address pt 4
        [DisplayFormat(DataFormatString = "{0:#####}",
            ApplyFormatInEditMode = true)]
        public Int32 ZipCode { get; set; }

        //Phone Number
        [DataType(DataType.PhoneNumber)]
        public Int64 PhoneNumber { get; set; }

        //BirthDate
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        //Credit Card
        [DisplayFormat(DataFormatString = "{0:####-####-####-####}",
            ApplyFormatInEditMode = true)]
        public Int32 CreditCard { get; set; }

        //SSN
        [DisplayFormat(DataFormatString = "{0:###-##-####}",
            ApplyFormatInEditMode = true)]
        public Int64 SSN { get; set; }

        //Popcorn Points 
        public Int32 PopcornPoints { get; set; }

        //Nav Property for Order
        public virtual List<Order> Orders { get; set; }





    }
}