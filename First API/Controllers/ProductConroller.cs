using First_API.Interface;
using First_API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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
        [HttpDelete]
        [Route("delete/{prodId}")]
        public IActionResult Delete(int prodId)
        {
            var data = _productData.GetProduct(prodId);
            if (data != null)
            {
                _productData.Delete(data);
                return Ok();
            }
            return NotFound($"No Data Found With {prodId} ");
        }

        [HttpPut]
        [Route("edit/{id}")]
        public IActionResult EditProduct(int id, product data)
        {
            var existingData = _productData.GetProduct(id);
            if (existingData != null)
            {
               id = existingData.Id;
                _productData.EditProduct(data);
            }
            return Ok(data);
            return Ok("Product Has Been Updated Successfully");
        }

    }
}

