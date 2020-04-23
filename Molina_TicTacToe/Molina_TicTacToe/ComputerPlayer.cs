using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molina_TicTacToe
{
    class ComputerPlayer : Player
    {
        private Board board;
        private BitArray otherPlayer;
        private int[] moves = { 4, 0, 2, 6, 8, 1, 3, 5, 7 };
        private BitArray testPieces;


        public override void MakeMove(ref int position)
        {
            if ((position = pickPosition(Pieces)) == Board.NOT_A_MOVE && (position = pickPosition(otherPlayer)) == Board.NOT_A_MOVE) 
            {
                for (int i = 0; position == Board.NOT_A_MOVE && i < moves.Length; i++)
                {
                    if (board.OpenPositions[moves[i]])
                    {
                        position = moves[i];
                    }
                }
            }
            if (position != Board.NOT_A_MOVE)
            {
                Pieces[position] = true;
                board.OpenPositions[position] = false;
            }
        }

        private int pickPosition(BitArray pieces)
        {
            int position = Board.NOT_A_MOVE;
            for (int i = 0; position == Board.NOT_A_MOVE && i < pieces.Length; i++)
            {
                testPieces = new BitArray(pieces);
                if (board.OpenPositions[i])
                {
                    testPieces[i] = true;
                    if (board.IsWinner(testPieces))
                    {
                        position = i;
                    }
                }
            }
            return position;
        }
        
        public ComputerPlayer(Board board, BitArray otherPlayer) : base()
        {
            this.board = board;
            this.otherPlayer = otherPlayer;
        }
    }
}
