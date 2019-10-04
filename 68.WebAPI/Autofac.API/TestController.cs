using Autofac.Domain.Controller;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Autofac.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : BaseApiController
    {
        [Route("[action]")]
        [HttpGet]
        public IActionResult Test1()
        {
            return Success("OK");
        }
    }
}
