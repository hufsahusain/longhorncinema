using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
using LonghornCinemaProject.Models;


namespace LonghornCinemaProject.DAL
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext()
           : base("MyDBConnection", throwIfV1Schema: false) { }

        public static AppDbContext Create()
        {
            return new AppDbContext();

        }

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

        //NOTE: This is a dbSet that you need to make roles work
        public DbSet<AppRole> AppRoles { get; set; }
    }
}