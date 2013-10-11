using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wonderboyz.Web.Models.View;

namespace Wonderboyz.Data.Interfaces
{
    public interface ICommentRepository
    {
        CommentViewModel GetById(int id);
        List<CommentViewModel> GetByBlogPostId(int Id, bool Approved = true);
        List<CommentViewModel> GetByCommentor(string Commentor, int?  BlogPostId, bool? Approved);
        List<CommentViewModel> GetByDateRange(int? BlogPostId, DateTime Start, DateTime End);
        
    }
}
