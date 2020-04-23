using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Molina_TicTacToe
{
    abstract class Player
    {
        private BitArray pieces;
        

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

        public abstract void MakeMove(ref int position);
    }
}
