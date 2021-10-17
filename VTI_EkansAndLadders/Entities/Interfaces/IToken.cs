using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTI_EkansAndLadders.Entities.Interfaces
{
    public interface IToken
    {
        string Name { get; }
        int GetTokenPosition();
        void SetTokenPosition(Cell cellNum);

    }
}
