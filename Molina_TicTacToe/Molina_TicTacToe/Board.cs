using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Molina_TicTacToe
{
    class Board
    {
        BitArray openPositions;
        int[,] winningCombos = {    {0,1,2},
                                    {3,4,5},
                                    {6,7,8},
                                    {0,3,6},
                                    {1,4,7},
                                    {2,5,8},
                                    {0,4,8},
                                    {2,4,6} };
        public static int NOT_A_MOVE = -1;

        public BitArray OpenPositions { get { return openPositions; } }
        public int[,] WinningCombos { get { return winningCombos; } }
        public Board()
        {
            openPositions = new BitArray(9, true);
        }

        public bool IsWinner(BitArray thePlayer)
        {
            bool winner = false;

            for (int rowIndex = 0; rowIndex < winningCombos.GetLength(0); rowIndex++)
            {
                if ((thePlayer[winningCombos[rowIndex, 0]]) && (thePlayer[winningCombos[rowIndex, 1]]) && (thePlayer[winningCombos[rowIndex, 2]]))
                    winner = true;
            }

            return winner;

        }

        public bool IsFull()
        {
            bool tie = true;

            for (int i = 0; tie && i < openPositions.Length; i++)
            {
                if (openPositions[i])
                {
                    tie = false;
                }
            }

            return tie;
        }

    }
}
