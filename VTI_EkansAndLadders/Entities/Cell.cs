using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTI_EkansAndLadders.Entities
{
    public class Cell
    {
        private int _cellNum;

        public Cell(int cellNum)
        {
            _cellNum = cellNum;
        }

        public int GetCellNum()
        {
            return _cellNum;
        }
    }
}
