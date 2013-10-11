using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Wonderboyz.Web.Models.View;
using Wonderboyz.Data.Interfaces;

namespace Wonderboyz.Web.Controllers
{
    public class CommentController : Controller
    {
        //
        // GET: /Comment/
        public ICommentRepository CommentRepository { get; set; }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Moderate(int? BlogPostId)
        {
            List<CommentViewModel> Comments;
            return View();
        }

    }
}
