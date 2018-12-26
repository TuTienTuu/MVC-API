namespace Web.Data.Infrastructure
{
    public class DbFactory : Disposeable, IDbFactory
    {
        private WebDbContext dbContext;

        public WebDbContext Init()
        {
            return dbContext ?? (dbContext = new WebDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}