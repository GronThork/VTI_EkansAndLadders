using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTI_EkansAndLadders.Entities
{
    public class Board
    {
        private Cell[] _cells;
        private Token _token;

        public Board()
        {
            //Create the board with 100 cells
            _cells = new Cell[100];
            for (int i = 1; i <= 100; i++)
            {
                Cell cell = new(i);
                _cells[i - 1] = cell;
            }

            _token = new(_cells[0]);
        }

        public Token Token()
        {
            return _token;
        }
    }
}
