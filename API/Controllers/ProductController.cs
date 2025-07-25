using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace BARTENDER_JOE
{
    [ApiController]
    [EnableCors]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {

        [HttpGet(Name = "GetProductById")]
        public Product Get(string productId)
        {
            GetProduct productObj = new GetProduct();
            return productObj.GetValidProduct(productId);
            
        }
    }
}
