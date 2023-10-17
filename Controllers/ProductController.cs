using Base_Backend.Model;
using Base_Backend.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Base_Backend.Controllers
{
    [Serializable]
    [ApiController]
    [Route("v1/products")]
    public class ProductController : ControllerBase
    {

        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [AcceptVerbs("GET")]
        [Route("GetAll")]
        public ActionResult<List<ProductEntity>> GetAll()
        {
            var products = _productRepository.GetAll();
            return Ok(products);
        }


        [AcceptVerbs("POST")]
        [Route("Save")]
        public ActionResult<ProductEntity> Save([FromBody ]ProductEntity product)
        {
            product =  _productRepository.Add(product);
            return Ok(product);
        }
    }
}
