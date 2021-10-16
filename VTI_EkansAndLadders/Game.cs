﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTI_EkansAndLadders.Entities;

namespace VTI_EkansAndLadders
{
    public class Game
    {
        private Board _board;
        private Token _token;

        public Board Board { get { return _board; } }
        public Token Token { get { return _token; } }


        public Game()
        {
            _board = new();
            _token = new(_board.Cells[0]);
        }


    }
}
