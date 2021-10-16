using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTI_EkansAndLadders.Entities
{
    public class Dice
    {
        Random rd;

        public Dice()
        {
            rd = new();
        }

        public int Roll()
        {
            return rd.Next(1, 7);
        }
    }
}
