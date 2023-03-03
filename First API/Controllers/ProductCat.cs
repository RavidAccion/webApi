using First_API.Interface;
using First_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace First_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCat : Controller
    {
        private readonly IProduct_cat _ProductCatData;

        public ProductCat(IProduct_cat ProductCatData)
        {
            _ProductCatData = ProductCatData;
        }


        [HttpPost]
        [Route("create")]
        public IActionResult Add(product_store data)

        {
            _ProductCatData.Add(data);
            return Created("/" + data, data);
        }

        [HttpGet]
        [Route("get")]
        public IActionResult Get()
        {
            var data = _ProductCatData.Get();
            return Ok(data);
        }
    }
}
