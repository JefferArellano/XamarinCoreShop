namespace VirtualShop.Web.Data
{
    using VirtualShop.Web.Data.Entities;

    public class ProductRepository:GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(DataContext context): base(context)
        {

        }

    }
}
