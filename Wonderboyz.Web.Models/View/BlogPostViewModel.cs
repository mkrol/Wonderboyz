using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wonderboyz.Web.Models.View
{
    public class BlogPostViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Keywords { get; set; }
        public DateTime PostDate { get; set; }
        public List<CommentViewModel> Comments { get; set; }
    }
}
