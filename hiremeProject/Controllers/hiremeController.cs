using hiremeProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hiremeProject.Controllers
{
    public class hiremeController : Controller
    {
        Model1 context = new Model1();
        // GET: hireme
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult add()
        {

            return View();
        }
        
        public ActionResult addPost(Post p)
        {
            p.id = context.Posts.Count() + 1;
            if (p.name != null)
            {
                context.Posts.Add(p);
                context.SaveChanges();
            }
            return RedirectToAction("index");
        }
        public ActionResult browseforjob()
        {
            List<Post> p = context.Posts.ToList();
            return View(p);
        }

       
        
        public ActionResult managePost()
        {
            List<Post> p = context.Posts.ToList();
           

            return View(p);
        }
        public ActionResult delete(int Id)
        {
            Post deletePost = context.Posts.FirstOrDefault(x => x.id == Id);
            context.Entry(deletePost).State = EntityState.Deleted;
            context.SaveChanges();
            List<Post> allPersons = context.Posts.ToList();
            return View("managePost", allPersons);

        }
        public ActionResult edit(int Id)
        {
            Post editPost = context.Posts.FirstOrDefault(x => x.id == Id);
            context.SaveChanges();
            return View(editPost);

        }
        public ActionResult editPost(int Id ,  Post p)
        {
            Post editPost = context.Posts.FirstOrDefault(x => x.id == Id);
            editPost.name = p.name;
            editPost.job = p.job;
            editPost.phoneNumber = p.phoneNumber;
            editPost.email = p.email;
            editPost.address = p.address;
            editPost.details = p.details;
            editPost.passwordPost = p.passwordPost;

            context.SaveChanges();
            List<Post> all = context.Posts.ToList();
            return View("managePost",all);

        }



    }
}