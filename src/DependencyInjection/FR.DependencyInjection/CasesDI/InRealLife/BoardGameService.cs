using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FR.DependencyInjection.CasesDI.InRealLife
{
    public class BoardGameService : IBoardGameService
    {
        private readonly IBoardGameRepository _boardGameRepository;

        public BoardGameService(IBoardGameRepository boardGameRepository)
        {
            _boardGameRepository = boardGameRepository;
        }

        public void AddBoardGame(BoardGame boardGame)
        {
            boardGame.Id = Guid.NewGuid();
            _boardGameRepository.AddBoardGame(boardGame);
        }
    }
}
