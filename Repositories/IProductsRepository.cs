using System.Collections.Generic;
using T_System_Web_Api.Model;

namespace T_System_Web_Api.Repositories
{
    public interface IProductsRepository
    {
        IEnumerable<Products> GetAllProducts();
        int AddProduct(Products products);
        int UpdateProduct(Products products);
        int DeleteProduct(int ProductId);
    }
}
