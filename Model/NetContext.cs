using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    public class NetContext : DbContext
    {
        public NetContext()
        : base("EfDbContext")
        {
        }
        public virtual IDbSet<Article> Articles { get; set; }
        public virtual IDbSet<Comment> Comments { get; set; }
    }
}
