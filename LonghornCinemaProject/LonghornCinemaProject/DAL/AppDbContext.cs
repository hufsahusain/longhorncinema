using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LonghornCinemaProject.Models;
using System.Data.Entity;


namespace LonghornCinemaProject.DAL
{
    public class AppDbContext:DbContext
    {
        //Constructor that invokes the base constructor
        public AppDbContext() : base("MyDBConnection") {}

        //Create the db set
        public DbSet<Customer>Customers { get; set; }
        //Create the db set
        public DbSet<Movie> Movies { get; set; }
        //Create the db set
        public DbSet<Order> Orders { get; set; }
        //Create the db set
        public DbSet<Showtime> Showtimes { get; set; }
        //Create the db set
        public DbSet<Seat> Seats { get; set; }
        //Create the db set
        public DbSet<Ticket> Tickets { get; set; }
        //Create the db set
        public DbSet<Genre> Genres { get; set; }
    }
}