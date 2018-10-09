using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TechTalk.Domain;
using TechTalk.Service;

namespace TechTalk.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<HelloWorldDTO>> Get()
        {
            try
            {
                var service = new HelloWorldService();
                var helloWorld = await Task.FromResult<HelloWorldDTO>(service.Get());

                return Ok(helloWorld);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
