namespace BinShop.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}