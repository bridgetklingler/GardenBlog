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
            ViewBag.PostId = id;

            return View();
        }

        [HttpPost]
        public ActionResult Create(Post post)
        {
            postRepo.Create(post);

            return RedirectToAction("../Review/Index/" + post.PostId);
        }


        [HttpGet]
        public ViewResult Delete(int id)
        {
            var model = postRepo.GetById(id);

            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(Post post)
        {
            int pid = post.PostId;

            postRepo.Delete(post);

            return RedirectToAction("../Review/Index/" + pid);
        }


        [HttpGet]
        public ViewResult Edit(int id)
        {
            ViewBag.PostId = id;

            var model = postRepo.GetById(id);

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Post post)
        {
            int pid = post.PostId;

            postRepo.Edit(post);

            return RedirectToAction("../Review/Index/" + pid);
        }
    }
}
