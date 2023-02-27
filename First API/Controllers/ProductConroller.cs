using First_API.Interface;
using First_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace First_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductConroller : Controller
    {
       
       
            private readonly Iproduct _productData;

            public ProductConroller(Iproduct productData)
            {
                _productData = productData;
            }


            [HttpPost]
            [Route("createProduct")]
            public IActionResult Add(product data)

            {
                _productData.Add(data);
                return Created("/" + data.Id, data);
            }

        [HttpGet]
        [Route("get")]
        public IActionResult Get()
        {
            var data = _productData.Get();
            return Ok(data);
        }
    }
    }

