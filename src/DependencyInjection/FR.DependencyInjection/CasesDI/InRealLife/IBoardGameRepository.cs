using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FR.DependencyInjection.CasesDI.InRealLife
{
    public interface IBoardGameRepository
    {
        void AddBoardGame(BoardGame boardGame);
    }
}
