using System.Data.Entity;
using DomainModel;

namespace Data
{
    public class EfContext : DbContext, IUnitOfWork
    {
        public DbSet<Post> Post { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public EfContext()
            : base("TavanGruop")
        {
        }

        #region IUnitOfWork Members

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }

        #endregion
    }
}