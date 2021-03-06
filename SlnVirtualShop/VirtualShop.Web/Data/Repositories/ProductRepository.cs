﻿namespace VirtualShop.Web.Data.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using System.Linq;
    using VirtualShop.Web.Data.Entities;

    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly DataContext context;

        public ProductRepository(DataContext context) : base(context)
        {
            this.context = context;
        }

        public IQueryable GetAllWithUsers()
        {
            return this.context.Products.Include(p => p.User);
        }
    }
}
