using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LonghornCinemaProject.DAL;
using LonghornCinemaProject.Models;

namespace LonghornCinemaProject.Utilities
{
    public static class GenerateOrderNumber
    {
        public static Int32 GetNextOrderNumber()
        {
            //we need a db context to connect to the database
            AppDbContext db = new AppDbContext();

            Int32 intMaxOrderNumber; //the current maximum course number
            Int32 intNextOrderNumber; //the course number for the next class

            if (db.Orders.Count() == 0) //there are no courses in the database yet
            {
                intMaxOrderNumber = 10000; //course numbers start at 10001
            }
            else
            {
                intMaxOrderNumber = db.Orders.Max(c => c.OrderNumber); //this is the highest number in the database right now
            }

            //add one to the current max to find the next one
            intNextOrderNumber = intMaxOrderNumber + 1;

            //return the value
            return intNextOrderNumber;
        }

    }
}