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
    public class LifeCycleController : ControllerBase
    {
        private readonly LifeCycleService _lifeCycleService1;
        private readonly LifeCycleService _lifeCycleService2;

        public LifeCycleController(LifeCycleService lifeCycleService1, LifeCycleService lifeCycleService2)
        {
            this._lifeCycleService1 = lifeCycleService1;
            this._lifeCycleService2 = lifeCycleService2;
        }

        [HttpGet]
        public string Get()
        {

            var lifeCycle = @$"Firt Instance: {Environment.NewLine} 
                               {_lifeCycleService1.Transient.LifeCycleId + Environment.NewLine}
                               {_lifeCycleService1.Scoped.LifeCycleId + Environment.NewLine}
                               {_lifeCycleService1.Singleton.LifeCycleId + Environment.NewLine}
                               {_lifeCycleService1.SingletonInstance.LifeCycleId + Environment.NewLine}
                               {Environment.NewLine}
                               {Environment.NewLine}
                              Second Instance: {Environment.NewLine}
                               {_lifeCycleService2.Transient.LifeCycleId + Environment.NewLine}
                               {_lifeCycleService2.Scoped.LifeCycleId + Environment.NewLine}
                               {_lifeCycleService2.Singleton.LifeCycleId + Environment.NewLine}
                               {_lifeCycleService2.SingletonInstance.LifeCycleId + Environment.NewLine}
                              ";
            return lifeCycle;
        }
    }
}
