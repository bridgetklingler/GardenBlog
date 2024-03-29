﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GardenBlog.Repositories;
using Microsoft.AspNetCore.Mvc;
using GardenBlog.Models;

namespace GardenBlog.Controllers
{
    public class CategoryController : Controller
    {
        IRepository<Category> catRepos;

        public CategoryController(IRepository<Category> catRepos)
        {
            this.catRepos = catRepos;
        }

        public ViewResult Index()
        {
            var model = catRepos.GetAll();
            return View(model);
        }


        public ViewResult Details(int id)
        {
            var model = catRepos.GetById(id);
            return View(model);
        }


    }
}