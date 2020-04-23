using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molina_TicTacToe
{
    class HumanPlayer : Player
    {
        public override void MakeMove(ref int position)
        {
            Pieces[position] = true;
        }
    }
}
