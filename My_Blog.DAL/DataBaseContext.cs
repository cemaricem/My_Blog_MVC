using My_Blog.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Blog.DAL
{
    public class DataBaseContext:DbContext
    {
        public DbSet <MyBlogUser> MyBlogUsers{ get; set; }
    }
}
