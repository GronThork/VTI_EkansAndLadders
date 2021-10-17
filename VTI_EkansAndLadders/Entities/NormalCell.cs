using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTI_EkansAndLadders.Entities.Interfaces;

namespace VTI_EkansAndLadders.Entities
{
    public class NormalCell : Cell
    {
        private int _cellNum;

        public NormalCell(int cellNum)
        {
            _cellNum = cellNum;
        }

        public override int GetCellNum()
        {
            return _cellNum;
        }
    }
}
