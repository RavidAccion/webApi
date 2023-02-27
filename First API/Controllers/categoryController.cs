using First_API.Interface;
using First_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace First_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class categoryController : Controller
    {
        private readonly Icategory _catData;

        public categoryController(Icategory catData)
        {
            _catData = catData;
        }


        [HttpPost]
        [Route("create")]
        public IActionResult Add(category data)
        {
            _catData.Add(data);
            return Created("/" + data.Id, data);
        }

        [HttpGet]
        [Route("get")]
        public IActionResult Get()
        {
            var data = _catData.Get();
            return Ok(data);
        }
    }
}
