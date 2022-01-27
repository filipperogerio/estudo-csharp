using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FR.DependencyInjection.CasesDI.InRealLife;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FR.DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyInjectionController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromServices] IBoardGameService boardGameService,  [FromBody] BoardGame boardGame)
        {
            boardGameService.AddBoardGame(boardGame);

            return Ok(new
            {
                success = true,
                data = boardGame,
                resource = $"{Request.Scheme}://{Request.Host}{Request.Path}/{boardGame.Id}"
            });
        }
    }
}
