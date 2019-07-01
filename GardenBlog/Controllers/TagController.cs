using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GardenBlog.Models;
using GardenBlog.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GardenBlog.Controllers
{
    public class TagController : Controller
    {
        private IRepository<Tag> tagRepos;

        public TagController(IRepository<Tag> tagRepos)
        {
            this.tagRepos = tagRepos;
        }

        public ViewResult Index()
        {
            var model = tagRepos.GetAll();
            return View(model);
        }

        public ActionResult Details(int id)
        {
            var model = tagRepos.GetById(id);
            return View(model);
        }

        [HttpGet]
        public ActionResult AddTags(int id)
        {
            ViewBag.PostId = id;
            var model = tagRepos.GetAll();
            return View(model);
        }

        [HttpPost]
        public ActionResult AddTags(PostTag postTag)
        {
            
        }

    }
}