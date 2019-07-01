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
            modelBuilder.Entity<PostTag>()
                .HasKey(x => new { x.PostId, x.TagId });

            modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    PostId = 1,
                    CategoryId = 1,
                    TagId = 7,
                    Author = "Blair",
                    Title = "Spider Plant",
                    Body = "I've found that the spider plant is the most effective at cleaning the air in my home. As someone with asthma, I can attest that this plant has done wonders for my breathing!",
                    TimeStamp = DateTime.Now,
                },
                new Post
                {
                    PostId = 2,
                    CategoryId = 1,
                    TagId= 2,
                    Author = "Bridget",
                    Title = "English Ivy",
                    Body = "I know this plant is easy to care for inside, but does anyone else have an issue with the ivy climbing on every other plant within a 5 mile radius? Asking for a friend...",
                    TimeStamp = DateTime.Now,
                },
                new Post
                {
                    PostId = 3,
                    CategoryId = 1,
                    TagId=5,
                    Author = "Kyle",
                    Title = "Burning Bush",
                    Body = "I just planted a burning bush off my back porch and the leaves all fell off within the week. Is it dead or just didn't take the transplant well?",
                    TimeStamp = DateTime.Now,
                },
                new Post
                {
                    PostId = 4,
                    CategoryId = 2,
                    TagId= 3,
                    Author = "Elise",
                    Title = "Asiatic Lilies",
                    Body = "Last year I planted 4 asiatic lily plants and after my dog dug them up on multiple occassions, I just assumed they were dead. But this year, I have 9 plants growing! I'm so excited!",
                    TimeStamp = DateTime.Now,
                },

                new Post
                {
                    PostId = 5,
                    CategoryId = 2,
                    TagId= 6,
                    Author = "Peter",
                    Title = "Lily Pads",
                    Body = "I have a little bird bath fountain that I just put lily pads in. Now I have a couple peepers and the birds seem to not be using it anymore. Do you think the frogs scared them away? Or are birds scared of lily pads and I just didn't know about it?",
                    TimeStamp = DateTime.Now,
                },

                new Post
                {
                    PostId = 6,
                    CategoryId = 1,
                    TagId=4,
                    Author = "Miranda",
                    Title = "Sunflowers",
                    Body = "I just came across this entire acre field that plants sunflowers every year outside of Avon. It's so gorgeous, you have to check it out! It's so bright and yellow, and such a fun walk thorugh the field, it's a must do in the 2 weeks they're in full bloom!",
                    TimeStamp = DateTime.Now,
                },

                new Post
                {
                    PostId = 7,
                    CategoryId = 2,
                    TagId = 1,
                    Author = "Travis",
                    Title = "Mulch",
                    Body = "Black mulch beware!! I've found that the black mulch actually has overheated my softer plants. Just make sure to keep a good eye out on your plants after laying mulch. The black mulch tends to fade rather quickly, so the first 2 weeks are key.",
                    TimeStamp = DateTime.Now,
                });


            modelBuilder.Entity<Tag>().HasData(
                new Tag
                {
                    TagId = 1,
                    TagName = "mulch",
                },

                new Tag
                {
                    TagId = 2,
                    TagName = "ivy"
                },

                 new Tag
                 {
                     TagId = 3,
                     TagName = "orange",
                 }, 
                 
                 new Tag
                 {
                     TagId = 4,
                     TagName = "colorful",
                 },
                 
                 new Tag
                 {
                     TagId = 5,
                     TagName = "high-maintenance",
                 }, 
                 
                 new Tag
                 {
                     TagId = 6,
                     TagName = "easy-watering",
                 }, 
                 
                 new Tag
                 {
                     TagId = 7,
                     TagName = "direct-sun",
                 },

                 new Tag
                 {
                     TagId = 8,
                     TagName = "low-maintenance",
                 });


            modelBuilder.Entity<PostTag>().HasData(
                new PostTag
                {
                    PostId = 1,
                    TagId = 2
                },
                new PostTag
                {
                    PostId = 2,
                    TagId = 1
                },
                new PostTag
                {
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
