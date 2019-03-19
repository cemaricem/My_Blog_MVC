using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Blog.Entities
{
    public class EntityBase
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Descrition { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string ModifiedUsername { get; set; }
    }
}
