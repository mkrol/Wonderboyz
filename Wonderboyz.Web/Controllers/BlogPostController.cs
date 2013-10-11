using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Wonderboyz.Data.Interfaces;
using Wonderboyz.Web.Models.View;


namespace Wonderboyz.Web.Controllers
{
    public class BlogPostController : Controller
    {
        //
        // GET: /Post/
        public IBlogPostRepository BlogPostRepository { get; set; }

        public ActionResult Index(string UniqueBlogName)
        {
            BlogPostViewModel model = BlogPostRepository.GetByUniqueName(UniqueBlogName);
            return View(model);
        }

        

    }
}
