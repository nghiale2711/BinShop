using System;

namespace BinShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        BinShopDbContext Init();
    }
}