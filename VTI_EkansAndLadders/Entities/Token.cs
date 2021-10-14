using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTI_EkansAndLadders.Entities
{
    public class Token
    {
        Cell _position;

        public Token(Cell initialCell)
        {
            _position = initialCell;
        }
        public int GetTokenPosition()
        {
            return _position.GetCellNum();
        }

        public void SetTokenPosition(Cell cellNum)
        {
            _position = cellNum;
        }
    }
}