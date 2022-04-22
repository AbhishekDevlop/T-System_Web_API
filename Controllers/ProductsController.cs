using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using T_System_Web_Api.Model;
using T_System_Web_Api.Services;

namespace T_System_Web_Api.Controllers
{
    public class ProductsController : ControllerBase
    {
        private readonly IProductsServices iprodSer;

        public ProductsController(IProductsServices iprodSer)
        {
            this.iprodSer = iprodSer;
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/Products/GetProducts")]
        public IActionResult GetProducts()
        {
            return new ObjectResult(iprodSer.GetAllProduct());
        }
        [HttpPost]
        [Route("AddProduct")]
        public IActionResult AddProduct(Products products)
        {
            return new ObjectResult(iprodSer.AddProduct(products));
        }

        [HttpPost]
        [Route("UpdateProduct")]
        public IActionResult UpdateProduct(Products products)
        {
            return new ObjectResult(iprodSer.UpdateProduct(products));
        }
        [HttpGet]
        [Route("DeleteProduct/{ProductId}")]
        public IActionResult DeleteStudent(int ProductId)
        {
            return new ObjectResult(iprodSer.DeleteProduct(ProductId));
        }
    }
}
