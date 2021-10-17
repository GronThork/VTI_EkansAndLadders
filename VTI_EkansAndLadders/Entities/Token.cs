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
        private ICell _position;
        private string _name;

        public string Name { get { return _name; } }

        public Token(ICell initialCell, string name)
        {
            _position = initialCell;
            _name = name;
        }
        public int GetPosition()
        {
            return _position.GetCellNum();
        }

        public void SetTokenPosition(ICell cellNum)
        {
            _position = cellNum;
        }
    }
}