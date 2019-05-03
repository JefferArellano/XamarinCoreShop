namespace VirtualShop.Web.Data.Repositories
{
    using System.Linq;
    using VirtualShop.Web.Data.Entities;

    public interface IProductRepository: IGenericRepository<Product>
    {
        IQueryable GetAllWithUsers();
    }
}
