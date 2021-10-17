using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTI_EkansAndLadders.Entities.Interfaces;

namespace VTI_EkansAndLadders.Entities
{
    public class Cell : ICell
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
