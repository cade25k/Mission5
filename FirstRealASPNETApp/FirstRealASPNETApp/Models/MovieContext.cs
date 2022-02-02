using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstRealASPNETApp.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {

        }

        public DbSet<Movie> movies { get; set; }
        public DbSet<Category> categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Action/Adventure"},
                new Category { CategoryId = 2, CategoryName = "Comedy" },
                new Category { CategoryId = 3, CategoryName = "Drama" },
                new Category { CategoryId = 4, CategoryName = "Family" },
                new Category { CategoryId = 5, CategoryName = "Horror/Suspense" },
                new Category { CategoryId = 6, CategoryName = "Miscellaneous" },
                new Category { CategoryId = 7, CategoryName = "Television" },
                new Category { CategoryId = 8, CategoryName = "VHS" }
            );

            mb.Entity<Movie>().HasData(

                new Movie
                {
                    MovieId = 1,
                    title = "The Dark Knight",
                    year = 2008,
                    director = "Christopher Nolan",
                    rating = "PG-13",
                    categoryId = 1,
                    edited = false,
                },
                new Movie
                {
                    MovieId = 2,
                    title = "Spiderman No Way Home",
                    year = 2021,
                    director = "Jon Watts",
                    rating = "PG-13",
                    categoryId = 1,
                    edited = false,
                },
                new Movie
                {
                    MovieId = 3,
                    title = "The Bourne Ultimatum",
                    year = 2007,
                    director = "Paul Greengrass",
                    rating = "PG-13",
                    categoryId = 1,
                    edited = false,
                }
            );
        }
    }
}
