using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wonderboyz.Web.Models.View;

namespace Wonderboyz.Data.Interfaces
{
    public interface IBlogPostRepository
    {
        BlogPostViewModel GetByUniqueName(string name);
        List<BlogPostViewModel> GetMostRecent(int IndexCount = 5);
        List<BlogPostViewModel> Search(string SearchText);
        List<BlogPostViewModel> SearchByKeywords(List<string> Keywords);
    }
}
