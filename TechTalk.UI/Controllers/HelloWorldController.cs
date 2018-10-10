using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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
        [Route("list")]
        public async Task<ActionResult<List<HelloWorldDTO>>> List()
        {
            try
            {

                var helloWorlds = await Task.FromResult<List<HelloWorldDTO>>(HelloWorldService.List());

                return Ok(helloWorlds);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult<HelloWorldDTO>> Get([FromQuery(Name = "is_valid")] bool isValid = true)
        {
            try
            {
                var helloWorlds = await Task.FromResult<HelloWorldDTO>(HelloWorldService.Get(isValid));

                return Ok(helloWorlds);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
