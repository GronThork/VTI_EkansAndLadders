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
        public static NormalCell[] GetDefaultCells()
        {
            NormalCell[] cells = new NormalCell[100];

            for (int i = 0; i < 100; i++)
            {
                cells[i] = new NormalCell(i);
            }

            return cells;
        }
    }
}
