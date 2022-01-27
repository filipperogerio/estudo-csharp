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
    public class GenericsController : ControllerBase
    {
        private readonly IGenerics<GenericsObject> generics;

        public GenericsController(IGenerics<GenericsObject> generics)
        {
            this.generics = generics;
        }

        [HttpPost]
        public void Post(GenericsObject genericsObject)
        {
            generics.ExecuteMyGeneric(genericsObject);
        }
    }
}
