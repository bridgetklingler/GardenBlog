﻿using System;
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
    }
}
