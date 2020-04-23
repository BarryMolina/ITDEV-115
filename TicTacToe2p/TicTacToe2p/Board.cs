using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe2p
{
    class Board
    {
        int[,] winningCombos = {    {0,1,2},
                                    {3,4,5},
                                    {6,7,8},
                                    {0,3,6},
                                    {1,4,7},
                                    {2,5,8},
                                    {0,4,8},
                                    {2,4,6} };
        int count;

        public Board()
        {

            count = 0;
        }

        public bool IsWinner(Player thePlayer)
        {
            bool winner = false;

            for (int rowIndex = 0; rowIndex < winningCombos.GetLength(0); rowIndex++)
            {
                if ((thePlayer.Pieces[winningCombos[rowIndex, 0]]) && (thePlayer.Pieces[winningCombos[rowIndex, 1]]) && (thePlayer.Pieces[winningCombos[rowIndex, 2]]))
                    winner = true;
            }

            return winner;

        }

        public bool IsFull()
        {
            bool tie = false;

            if (count >= 8)
                tie = true;

            count++;

            return tie;
        }

    }
}
