using System.Collections.Generic;
using T_System_Web_Api.Model;

namespace T_System_Web_Api.Services
{
    public interface IProductsServices
    {
        IEnumerable<Products> GetAllProduct();
        int AddProduct(Products products);
        int UpdateProduct(Products products);
        int DeleteProduct(int ProductId);
    }
}
