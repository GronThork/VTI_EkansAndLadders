using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTI_EkansAndLadders.Entities.Interfaces;

namespace VTI_EkansAndLadders.Entities
{
    public class Token : IToken
    {
        private Cell _position;
        private string _name;

        public string Name { get { return _name; } }

        public Token(Cell initialCell, string name)
        {
            _position = initialCell;
            _name = name;
        }
        public int GetPosition()
        {
            return _position.GetCellNum();
        }

        public void SetTokenPosition(Cell cellNum)
        {
            _position = cellNum;
        }
    }
}