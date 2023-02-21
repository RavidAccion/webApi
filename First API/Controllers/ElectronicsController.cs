using First_API.Data;
using First_API.Interface;
using First_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using First_API.Services;

namespace First_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElectronicsController : ControllerBase
    {
        private IElectronicscs _elecData;

        public ElectronicsController(IElectronicscs elecData)
        {
            _elecData = elecData;
        }


        [HttpPost]
        [Route("create")]
        public IActionResult Add(Electronics elecs)
        {
            _elecData.Add(elecs);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host +
                HttpContext.Request.Path + "/" + elecs.Id, elecs);
        }

    }
}
