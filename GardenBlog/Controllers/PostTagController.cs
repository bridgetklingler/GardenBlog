﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GardenBlog.Controllers
{
    public class PostTagController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}