using System.Collections.Generic;
using T_System_Web_Api.Model;
using T_System_Web_Api.Repositories;

namespace T_System_Web_Api.Services
{
    public class ProductsServices : IProductsServices
    {
        private readonly IProductsRepository iprodrepo;

        public ProductsServices(IProductsRepository iprodrepo)
        {
            this.iprodrepo = iprodrepo;
        }
        
        public int AddProduct(Products products)
        {
            return iprodrepo.AddProduct(products);
        }

        public int DeleteProduct(int ProductId)
        {
            return iprodrepo.DeleteProduct(ProductId);
        }

        public IEnumerable<Products> GetAllProduct()
        {
            return iprodrepo.GetAllProducts();
        }

        public int UpdateProduct(Products products)
        {
           return iprodrepo.UpdateProduct(products);
        }
    }
}
