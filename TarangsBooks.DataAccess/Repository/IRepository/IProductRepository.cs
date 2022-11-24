using System;
using System.Collections.Generic;
using System.Text;
using TarangsBooks.Models;

namespace TarangsBooks.DataAccess.Repository.IRepository
{
    public interface IProductRepository :IRepository<Product>
    {
        void Update(Product product);
    }
}
