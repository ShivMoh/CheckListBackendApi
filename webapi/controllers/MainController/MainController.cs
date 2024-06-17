using Microsoft.AspNetCore.Mvc;
using web.models;
using webapi.models.kitchen;
using webapi.test;

namespace webap.controllers
{

    [ApiController]
    [Route("api/controller")]
    public class MainController : Controller
    {
        // GET: MainController

        [HttpGet]
        public ActionResult Index()
        {
            return Ok("this is working now");
        }

        [HttpPost]
        public async Task<IActionResult> Create(Aromatics test) {

            return Ok("hello");
        }

    }
}
