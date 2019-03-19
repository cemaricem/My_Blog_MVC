using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Blog.Entities
{
    public class Note:EntityBase
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public bool IsDraft { get; set; }
        public int LikeCount { get; set; }
        public int CategoryId { get; set; }

        public virtual MyBlogUser Owner { get; set; }
        public virtual List<Comment> comments { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<Liked> Likes { get; set; }
    }
}
