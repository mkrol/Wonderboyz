using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wonderboyz.Data.Interfaces;
using Wonderboyz.Web.Models.View;

namespace Wonderboyz.Data
{
    public class BlogPostRepository : IBlogPostRepository
    {
        public BlogPostViewModel GetByUniqueName(string name)
        {
            return new BlogPostViewModel();
        }


        public List<BlogPostViewModel> GetMostRecent(int IndexCount = 5)
        {
            throw new NotImplementedException();
        }

        public List<BlogPostViewModel> Search(string SearchText)
        {
            throw new NotImplementedException();
        }
        public List<BlogPostViewModel> SearchByKeywords(List<string> Keywords)
        {
            throw new NotImplementedException();
        }

    }
}
