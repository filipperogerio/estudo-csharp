using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FR.DependencyInjection.CasesDI;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FR.DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MultipleClassesController : ControllerBase
    {
        private readonly Func<string, IFly> _service;

        public MultipleClassesController(Func<string, IFly> service)
        {
            _service = service;
        }

        [HttpGet("{whoIsFlying}")]
        public string Get(string whoIsFlying)
        {
            return _service(whoIsFlying).Fly();
        }
    }
}
