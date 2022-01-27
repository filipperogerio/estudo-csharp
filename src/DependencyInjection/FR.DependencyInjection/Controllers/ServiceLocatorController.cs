using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FR.DependencyInjection.CasesDI.InRealLife;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace FR.DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceLocatorController : ControllerBase
    {
        private readonly IServiceProvider _serviceProvider;

        public ServiceLocatorController(IServiceProvider serviceProvider)
        {
            this._serviceProvider = serviceProvider;
        }

        [HttpPost]
        public IActionResult Post([FromBody] BoardGame boardGame)
        {
            _serviceProvider.GetRequiredService<IBoardGameService>().AddBoardGame(boardGame);

            return Ok(new
            {
                success = true,
                data = boardGame,
                resource = $"{Request.Scheme}://{Request.Host}{Request.Path}/{boardGame.Id}"
            });
        }
    }
}
