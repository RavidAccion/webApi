using First_API.Interface;
using First_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace First_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class catStore : Controller
    {
        private readonly IcatStore _catstoreData;

        public catStore(IcatStore catstoreData)
        {
            _catstoreData = catstoreData;
        }


        [HttpPost]
        [Route("create")]
        public IActionResult Add(cat_store data)

        {
            _catstoreData.Add(data);
            return Created("/" + data, data);
        }

        [HttpGet]
        [Route("get")]
        public IActionResult Get()
        {
            var data = _catstoreData.Get();
            return Ok(data);
        }
    }
}
