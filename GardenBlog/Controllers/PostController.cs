using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GardenBlog.Repositories;
using GardenBlog.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GardenBlog
{
    public class PostController : Controller
    {
        IRepository<Post> postRepo;

        public PostController(IRepository<Post> postRepo)
        {
            this.postRepo = postRepo;
        }


        public ViewResult Index()
        {
            var model = postRepo.GetAll();

            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = postRepo.GetById(id);

            return View(model);
        }


        [HttpGet]
        public ViewResult Create(int id)
        {
            ViewBag.CategoryId = id;
            
            return View();
        }

        [HttpPost]
        public ActionResult Create(Post post)
        {
            postRepo.Create(post);

            return RedirectToAction("../Tag/AddTags/" + post.PostId);
        }


        [HttpGet]
        public ViewResult Delete(int id)
        {
            ViewBag.PostId = id;

            var model = postRepo.GetById(id);

            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(Post post)
        {
            postRepo.Delete(post);

            return RedirectToAction("../Category/Index/");
        }


        [HttpGet]
        public ViewResult Edit(int id)
        {
            var model = postRepo.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Post post)
        {
            postRepo.Edit(post);

            return RedirectToAction("../Category/Details/" +post.CategoryId);
        }
    }
}
