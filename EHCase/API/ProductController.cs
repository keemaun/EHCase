using EHCase.Model;
using EHCase.Repository.Interfaces;
using System.Web.Http;

namespace EHCase.API
{
    [Route("api/[controller]")]
    public class ProductController
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        // GET: api/Product/cheapest?top=5
        [HttpGet("cheapest")]
        public async Task<HttpResponseMessage>GetTopXCheapestProductsAsync( int top)
        {
            var products = await _productRepository.GetTopXCheapestProductsAsync(top);
            return Ok(products);
        }

    }
}
