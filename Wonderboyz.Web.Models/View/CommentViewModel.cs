using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wonderboyz.Web.Models.View
{
    public class CommentViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string CommentText { get; set; }
        public bool Approved { get; set; }
        public DateTime EnteredDate { get; set; }
        public DateTime ApprovalDate {get;set;}
    }
}
