using ResetAth.AutofacMvc.DAL.Contract;
using ResetAth.AutofacMvc.Models;
using ResetAth.AutofacMvc.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResetAth.AutofacMvc.Controllers
{
    public class PostController : Controller
    {
        private IPostRepository _postRepository;

        public PostController(IPostRepository repo)
        {
            this._postRepository = repo;
        }

        public ActionResult Index()
        {
            IEnumerable<Post> posts = this._postRepository.GetAll();
            return View(posts);
        }

        public ActionResult Single(int id)
        {
            Post post = this._postRepository.GetById(id);
            return View(post);
        }

        [HttpPost]
        public ActionResult Add(PostViewModel model)
        {
            if (ModelState.IsValid)
            {
                this._postRepository.Add(new Post()
                {
                    Title = model.Title,
                    Content = model.Content,
                    PathToImage = model.PathToImage
                });
            }

            return RedirectToAction("Index");
        }
    }
}