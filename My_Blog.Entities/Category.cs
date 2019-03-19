using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Blog.Entities
{
    public class Category:EntityBase
    {
        public string Title { get; set; }
        public string Descrition { get; set; }


        public virtual List<Note> Notes { get; set; }
    }
}
