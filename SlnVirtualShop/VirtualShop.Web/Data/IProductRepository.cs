namespace VirtualShop.Web.Data
{
    using System.Linq;
    using VirtualShop.Web.Data.Entities;

    public interface IProductRepository: IGenericRepository<Product>
    {
        IQueryable GetAllWithUsers();
    }
}
