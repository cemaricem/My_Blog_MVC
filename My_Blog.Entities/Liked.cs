using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Blog.Entities
{

    public class Liked
    {
        public int Id { get; set; }
        public Note Note { get; set; }
        public MyBlogUser LikedUser { get; set; }

    }
}
