namespace Data
{
    public class Context<T> : Framework.DataLayer.Context<T> where T : class
    {
        public Context(string db)
            : base(new EfContext(db))
        {
        }
    }
}