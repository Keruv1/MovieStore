using System;
using MovieStore.Entities;
using Microsoft.EntityFrameworkCore;



namespace MovieStore.DBOperations
{
    public interface IMovieDBContext
    {
        public DbSet<Genre> Genres {get;set;}
        public DbSet<Movie> Movies {get;set;}
        public DbSet<Director> Directors {get;set;}
        public DbSet<Customer> Customers {get;set;}
        public DbSet<Order> Orders {get;set;}
        public DbSet<Actor> Actors {get;set;}

        int SaveChanges();
    }
}