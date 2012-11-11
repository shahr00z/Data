using System.Data.Entity.Infrastructure;

namespace Data
{
    public class MigrationsContextFactory : IDbContextFactory<EfContext>
    {
        public EfContext Create()
        {
            return new EfContext("DataBase");
        }
    }
}