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
    public class InRealLife : ControllerBase
    {
        private readonly IBoardGameService _boardGameService;

        public InRealLife(IBoardGameService boardGameService)
        {
            _boardGameService = boardGameService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] BoardGame boardGame)
        {
            _boardGameService.AddBoardGame(boardGame);

            return Ok(new
            {
                success = true,
                data = boardGame,
                resource = $"{Request.Scheme}://{Request.Host}{Request.Path}/{boardGame.Id}"
            });
        }
    }
}
