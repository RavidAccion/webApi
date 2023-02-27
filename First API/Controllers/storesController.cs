using First_API.Interface;
using First_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace First_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class storesController : Controller
    {
        private readonly Istores _storeData;

        public storesController(Istores storeData)
        {
            _storeData = storeData;
        }


        [HttpPost]
        [Route("createStore")]
        public IActionResult Add(stores data)
        {
            _storeData.Add(data);
            return Created("/" + data.store_id, data);
        }


        [HttpGet]
        [Route("get")]
        public IActionResult Get()
        {
            var data = _storeData.Get();
            return Ok(data);
        }
    }
}
