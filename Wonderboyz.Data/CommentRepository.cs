using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wonderboyz.Data.Interfaces;
using Wonderboyz.Web.Models.Edit;
using Wonderboyz.Web.Models.View;

namespace Wonderboyz.Data
{
    class CommentRepository : ICommentRepository
    {
        public CommentViewModel GetById(int id)
        {
            return new CommentViewModel();
        }

        public List<CommentViewModel> GetByBlogPostId(int Id, bool Approved = true)
        {
            throw new NotImplementedException();
        }
        public List<CommentViewModel> GetByCommentor(string Commentor, int? BlogPostId, bool? Approved)
        {
            throw new NotImplementedException();
        }
        public List<CommentViewModel> GetByDateRange(int? BlogPostId, DateTime Start , DateTime End)
        {
            throw new NotImplementedException();
        }
        
    }
}
