using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTI_EkansAndLadders.Entities;

namespace VTI_EkansAndLaddersTests.Helpers
{
    internal class CellHelper
    {
        public static Cell[] GetDefaultCells()
        {
            Cell[] cells = new Cell[100];

            for (int i = 0; i < 100; i++)
            {
                cells[i] = new Cell(i);
            }

            return cells;
        }
    }
}
