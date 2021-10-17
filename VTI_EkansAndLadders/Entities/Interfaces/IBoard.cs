using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTI_EkansAndLadders.Entities.Interfaces
{
    public interface IBoard
    {
        void MoveToken(int steps, IToken token);
        bool IsGameOver(IToken token);
    }
}
