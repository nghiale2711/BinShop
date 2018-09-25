namespace BinShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private BinShopDbContext dbContext;

        public BinShopDbContext Init()
        {
            return dbContext ?? (dbContext = new BinShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}