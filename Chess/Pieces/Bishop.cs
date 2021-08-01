using System;
using System.Collections.Generic;
namespace ChessLib.Pieces
{
    public class Bishop : Piece
    {
        public Bishop(bool color, Square square) : base(color, square)
        {
            base.Moves = new List<(int, int)>()
            {
                (1, 1),
                (2, 2),
                (3, 3),
                (4, 4),
                (5, 5),
                (6, 6),
                (7, 7),
            };
        }
    }
}
