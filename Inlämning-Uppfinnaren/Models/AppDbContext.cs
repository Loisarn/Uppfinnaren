using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Uppfinnaren.ViewModels;


namespace Uppfinnaren.Models
{
   
    public class AppDbContext : DbContext
    { 

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Art> Arts { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Animals" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Utensils" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Bowls" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Toys" });
        

        modelBuilder.Entity<Art>().HasData(new Art
        {
            ArtId = 1,
            Name = "Monkey",
            Price = 9,
            Description = "a wooden monkey",
            ImageUrl = "/Images/apa.jpg",
            ArtofTheWeek = true,
            CategoryId = 1
        });


        modelBuilder.Entity<Art>().HasData(new Art
        {
            ArtId = 2,
            Name = "Bear",
            Price = 11,
            Description = "a wooden bear",
            ImageUrl = "/Images/bear.jpg.png",
            ArtofTheWeek = true,
            CategoryId = 1
        });

        modelBuilder.Entity<Art>().HasData(new Art
        {
            ArtId = 3,
            Name = "Bunny",
            Price = 8,
            Description = "a wooden bunny",
            ImageUrl = "/Images/bunny.jpg",
            ArtofTheWeek = true,
            CategoryId = 1
        });

        modelBuilder.Entity<Art>().HasData(new Art
        {
            ArtId = 4,
            Name = "Doves",
            Price = 13,
            Description = "wooden doves",
            ImageUrl = "/Images/doves.jpg",
            ArtofTheWeek = true,
            CategoryId = 1
        });

        modelBuilder.Entity<Art>().HasData(new Art
        {
            ArtId = 5,
            Name = "Elephant",
            Price = 10,
            Description = "a wooden elephant",
            ImageUrl = "/Images/elephant.jpg",
            ArtofTheWeek = false,
            CategoryId = 1
        });

        modelBuilder.Entity<Art>().HasData(new Art
        {
            ArtId = 6,
            Name = "Panda",
            Price = 10,
            Description = "a wooden monkey",
            ImageUrl = "/Images/panda.jpg",
            ArtofTheWeek = true,
            CategoryId = 1
        });

        modelBuilder.Entity<Art>().HasData(new Art
        {
            ArtId = 7,
            Name = "Hippo",
            Price = 10,
            Description = "a wooden hippo",
            ImageUrl = "/Images/hippo.jpg.png",
            ArtofTheWeek = false,
            CategoryId = 1
        });

            modelBuilder.Entity<Art>().HasData(new Art
            {
                ArtId = 8,
                Name = "Dog",
                Price = 8,
                Description = "a wooden dog",
                ImageUrl = "/Images/dog.jpg",
                ArtofTheWeek = false,
                CategoryId = 1
            });

            modelBuilder.Entity<Art>().HasData(new Art
            {
                ArtId = 9,
                Name = "Bowl",
                Price = 13,
                Description = "a wooden bowl",
                ImageUrl = "/Images/bowls.jpg",
                ArtofTheWeek = false,
                CategoryId = 3
            });

            modelBuilder.Entity<Art>().HasData(new Art
            {
                ArtId = 10,
                Name = "Dark Bowls",
                Price = 13,
                Description = "a set of three dark bowls",
                ImageUrl = "/Images/dark.bowls.jpg",
                ArtofTheWeek = false,
                CategoryId = 3
            });

            modelBuilder.Entity<Art>().HasData(new Art
            {
                ArtId = 11,
                Name = "Bowl 2",
                Price = 13,
                Description = "Bowl spot",
                ImageUrl = "/Images/bowlspot.jpg",
                ArtofTheWeek = false,
                CategoryId = 3
            });

            modelBuilder.Entity<Art>().HasData(new Art
            {
                ArtId = 12,
                Name = "Colorful spoon",
                Price = 10,
                Description = "a set of colorful spoons.",
                ImageUrl = "/Images/colorspoon.jpg",
                ArtofTheWeek = true,
                CategoryId = 2
            });

            modelBuilder.Entity<Art>().HasData(new Art
            {
                ArtId = 13,
                Name = "Bowl & Spoon",
                Price = 14,
                Description = "A set with bowl and spoon",
                ImageUrl = "/Images/bowlspoon.jpg",
                ArtofTheWeek = true,
                CategoryId = 2
            });

            modelBuilder.Entity<Art>().HasData(new Art
            {
                ArtId = 14,
                Name = "Utensils",
                Price = 12.95M,
                Description = "Utensils made of wood",
                ImageUrl = "/Images/utensils.jpg",
                ArtofTheWeek = false,
                CategoryId = 2
            });

            modelBuilder.Entity<Art>().HasData(new Art
            {
                ArtId = 15,
                Name = "Twisted nightstand",
                Price = 20,
                Description = "A nightstand with a twist.",
                ImageUrl = "/Images/doubletwist.jpg.webp",
                ArtofTheWeek = false,
                CategoryId = 4
            });

            modelBuilder.Entity<Art>().HasData(new Art
            {
                ArtId = 16,
                Name = "Xbox",
                Price = 20,
                Description = "An Xbox made out of wood.",
                ImageUrl = "/Images/xbox.jpg",
                ArtofTheWeek = false,
                CategoryId = 4
            });
        }
    }
}
