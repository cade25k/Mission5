﻿// <auto-generated />
using FirstRealASPNETApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FirstRealASPNETApp.Migrations
{
    [DbContext(typeof(MovieContext))]
    partial class MovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("FirstRealASPNETApp.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Action/Adventure"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Family"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Horror/Suspense"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Miscellaneous"
                        },
                        new
                        {
                            CategoryId = 7,
                            CategoryName = "Television"
                        },
                        new
                        {
                            CategoryId = 8,
                            CategoryName = "VHS"
                        });
                });

            modelBuilder.Entity("FirstRealASPNETApp.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("categoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("lentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieId");

                    b.HasIndex("categoryId");

                    b.ToTable("movies");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            categoryId = 1,
                            director = "Christopher Nolan",
                            edited = false,
                            rating = "PG-13",
                            title = "The Dark Knight",
                            year = 2008
                        },
                        new
                        {
                            MovieId = 2,
                            categoryId = 1,
                            director = "Jon Watts",
                            edited = false,
                            rating = "PG-13",
                            title = "Spiderman No Way Home",
                            year = 2021
                        },
                        new
                        {
                            MovieId = 3,
                            categoryId = 1,
                            director = "Paul Greengrass",
                            edited = false,
                            rating = "PG-13",
                            title = "The Bourne Ultimatum",
                            year = 2007
                        });
                });

            modelBuilder.Entity("FirstRealASPNETApp.Models.Movie", b =>
                {
                    b.HasOne("FirstRealASPNETApp.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("categoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
