using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DomainModel;
using Framework.DataLayer;

namespace Data
{
    public class EfContext : DbContext
    {
        public EfContext(string db)
            : base(db)
        {
        }
        public DbSet<Post> Post { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }

    }

}