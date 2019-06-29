using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GardenBlog.Models;

namespace GardenBlog
{
    public class BlogContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<PostTag> PostTags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=GardenBlogDb;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString)
                        .UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    PostId = 1,
                    Author = "Blair",
                    Title = "Horror",
                    Body = "This was so scary, it's scary",
                    TimeStamp = DateTime.Now,
                },
                
                new Post
                {
                    PostId = 2,
                    Author = "Bridget",
                    Title = "Comedy",
                    Body = "Soooo funny",
                    TimeStamp = DateTime.Now,
                },

                new Post
                {
                    PostId = 3,
                    Author = "Travis",
                    Title = "Horror",
                    Body = "Kinda Creepy",
                    TimeStamp = DateTime.Now,
                });

            modelBuilder.Entity<Tag>().HasData(
                new Tag
                {
                    TagId = 1,
                    TagName = "funny",
                },

                new Tag
                {
                    TagId = 2,
                    TagName = "scary"
                });

            modelBuilder.Entity<PostTag>().HasData(
                new PostTag
                {
                    PostTagID = 1,
                    PostId = 1,
                    TagId = 2
                },
                new PostTag
                {
                    PostTagID = 2,
                    PostId = 2,
                    TagId = 1
                },
                new PostTag
                {
                    PostTagID = 3,
                    PostId = 3,
                    TagId = 2
                });

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    CategoryName = "Indoor"
                },

                new Category
                {
                    CategoryId = 2,
                    CategoryName = "Outdoor"
                });
        }
    }
}
