using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace TicTacToe2p
{
    class Player
    {
        BitArray pieces;

        public Player()
        {
            pieces = new BitArray(9, false);
        }

        public BitArray Pieces
        {
            get
            {
                return pieces;
            }
        }

        public void MakeMove(int position)
        {
            pieces[position] = true;
        }
    }
}
