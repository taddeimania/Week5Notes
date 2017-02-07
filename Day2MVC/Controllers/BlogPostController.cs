using Day2MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day2MVC.Controllers
{
    public class BlogPostController : Controller
    {
        BlogPostContext db = new BlogPostContext();

        // GET: BlogPost
        public ActionResult Index()
        {
            ViewBag.AllBlogPosts = db.BlogPosts.OrderByDescending(b => b.Created).ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Create(BlogPost blogPost)
        {
            using(var db = new BlogPostContext())
            {
                blogPost.Created = DateTime.Now;
                db.BlogPosts.Add(blogPost);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}