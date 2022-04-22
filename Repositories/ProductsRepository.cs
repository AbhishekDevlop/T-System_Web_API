using System.Collections.Generic;
using System.Linq;
using T_System_Web_Api.Entity;
using T_System_Web_Api.Model;

namespace T_System_Web_Api.Repositories
{
    public class ProductsRepository : IProductsRepository
    {
        StudentContext context;

        public ProductsRepository(StudentContext context)
        {
            this.context = context;
        }
        public int AddProduct(Products products)
        {
            context.Products.Add(products);
            context.SaveChanges();
            return 1;

        }

        public int DeleteProduct(int ProductId)
        {
           var res = context.Products.Where(p => p.ProductId == ProductId).SingleOrDefault();

            if (res != null)
            {
                context.Remove(res);
                context.SaveChanges();
                return 1;
            }
            else { return 0; }
        }

        public IEnumerable<Products> GetAllProducts()
        {
            return context.Products.ToList();
        }

        public int UpdateProduct(Products products)
        {
            //var stud = from s in context.Students where s.rollNo == student.rollNo select s;
            var stud = context.Products.Where(p => p.ProductId == products.ProductId).SingleOrDefault();
            if (stud != null)
            {
                stud.ProductName = products.ProductName;
                stud.ProductPrice = products.ProductPrice;
                context.SaveChanges();
                return 1;
            }
            else { return 0; }
        }

        
    }
}
